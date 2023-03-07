
using LangTrainerEntity.Entities.Lang;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Service
{
    internal class LangService
    {
        private static LangService instance;
        private readonly HttpClient _client = new();

        private LangService()
        { }

        public static LangService GetInstance()
        {
            if (instance == null)
            {
                instance = new LangService();
            }
            return instance;
        }

        public async Task<Expression> GetTokenData(string token, string lang)
        {
            Expression obj = null;
            var url = @$"https://localhost:44329/api/Lang/GetTokenData/?Expression={token}&Language={lang}";
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                obj = await response.Content.ReadAsAsync<Expression>();
            }
            return obj;
        }

        public async Task<FindResult> FindInDictionary(string word, Guid? langId, Guid? trLangId)
        {
            var url = @$"https://localhost:44329/api/lang/FindInDictionary/?SearchString={word}&LanguageId={langId}&TranslateLanguageId={trLangId}";
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsAsync<FindResult>();
                return res;
            }

            return null;
        }

    }
}
