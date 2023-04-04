

using LangTrainerClientModel.Services;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Services
{
    internal class WordListService
    {
        private static WordListService _instance;

        private WordListService() { }

        public static WordListService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WordListService();
            }
            return _instance;
        }

        public async Task<IEnumerable<WordListItem>> GetList(string word, Guid? langId)
        {
            return await HttpClientService.GetInstance().Get<IEnumerable<WordListItem>>(@"https://localhost:44329/api/WordList/GetList",
                new Dictionary<string, object>()
                {
                    {"SearchString", string.IsNullOrEmpty(word) ? "-" : word},
                    {"LanguageId", langId},
                });
        }


    }
}
