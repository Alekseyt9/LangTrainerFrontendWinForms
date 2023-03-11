
using LangTrainerClientModel.Services;
using LangTrainerClientModel.Services.LangService;
using LangTrainerEntity.Entities;
using LangTrainerFrontendWinForms.Services;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Service
{
    internal class LangService
    {
        private static LangService _instance;

        private List<Language> m_Langs;
        private List<Language> m_TrLangs;

        private LangService() { }

        public static LangService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LangService();
            }
            return _instance;
        }

        public async Task<Expression> GetTokenData(string token, Guid langId)
        {
            return await HttpClientService.GetInstance().Get<Expression>(@"https://localhost:44329/api/Dictionary/GetTokenData",
                new Dictionary<string, object>()
                {
                    {"Expression", token},
                    {"LanguageId", langId}
                });
        }

        public async Task<FindResult> FindInDictionary(string word, Guid? langId, Guid? trLangId)
        {
            return await HttpClientService.GetInstance().Get<FindResult>(@"https://localhost:44329/api/Dictionary/FindInDictionary",
                new Dictionary<string, object>()
                {
                    {"SearchString", word},
                    {"LanguageId", langId},
                    {"TranslateLanguageId", trLangId}
                });
        }

        public async Task<List<Language>> GetLanguages()
        {
            if (m_Langs == null)
            {
                m_Langs = await HttpClientService.GetInstance().Get<List<Language>>(@"https://localhost:44329/api/Dictionary/GetLanguages");
            }
            return m_Langs;
        }

        public async Task<List<Language>> GetTranslateLanguages()
        {
            if (m_TrLangs == null)
            {
                m_TrLangs = await HttpClientService.GetInstance().Get<List<Language>>(@"https://localhost:44329/api/Dictionary/GetTranslateLanguages");
            }
            return m_TrLangs;
        }

        public async Task<LoadResult> LoadInBase(WordInfo data)
        {
            return await HttpClientService.GetInstance().Get<LoadResult>(@"https://localhost:44329/api/Dictionary/LoadInBase",
                new Dictionary<string, object>()
                {
                    { "Expression", data.Expression },
                    { "LanguageId", data.LanguageId }
                });
        }

    }
}
