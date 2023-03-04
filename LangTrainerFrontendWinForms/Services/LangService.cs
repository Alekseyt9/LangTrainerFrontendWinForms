﻿
using LangTrainerEntity.Entities.Lang;

namespace LangTrainerFrontendWinForms.Service
{
    internal class LangService
    {
        private HttpClient _client = new HttpClient();

        public async Task<Expression> GetTokenData(string token, string lang)
        {
            Expression obj = null;
            var url = @$"https://localhost:44329/api/Lang/gettokendata/?Expression={token}&Language={lang}";
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                obj = await response.Content.ReadAsAsync<Expression>();
            }
            return obj;
        }

    }
}