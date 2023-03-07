
using LangTrainerCommon.Helpers;
using LangTrainerEntity.Entities;
using LangTrainerServices.Services;

namespace LangTrainerFrontendWinForms.Service
{
    internal class LangService
    {
        private static LangService instance;

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
            return await WebClientHelper.Get<Expression>(@"https://localhost:44329/api/Lang/GetTokenData",
                new Dictionary<string, object>()
                {
                    {"Expression", token},
                    {"Language", lang}
                });
        }

        public async Task<FindResult> FindInDictionary(string word, Guid? langId, Guid? trLangId)
        {
            return await WebClientHelper.Get<FindResult>(@"https://localhost:44329/api/lang/FindInDictionary",
                new Dictionary<string, object>()
                {
                    {"SearchString", word},
                    {"LanguageId", langId},
                    {"TranslateLanguageId", trLangId}
                });
        }

    }
}
