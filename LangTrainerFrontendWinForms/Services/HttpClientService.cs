
using LangTrainerFrontendWinForms.Model;
using Newtonsoft.Json;
using System.Text;

namespace LangTrainerFrontendWinForms.Services
{
    public class HttpClientService
    {
        private static HttpClient _httpClient;

        private static HttpClientService _instance;

        private HttpClientService() { }

        public static HttpClientService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HttpClientService();
            }
            return _instance;
        }

        private HttpClient GetClient()
        {
            if (_httpClient == null)
            {
                var client = new HttpClient()
                {
                    Timeout = TimeSpan.FromSeconds(3)
                };
                EnsureAuth(client);
                _httpClient = client;
            }

            EnsureAuth(_httpClient);
            return _httpClient;
        }

        private void EnsureAuth(HttpClient client)
        {
            var tokens = UserService.GetInstance().TokensAuth;
            if (tokens != null)
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokens.Token);
            }
        }

        public async Task Post(string url, Dictionary<string, object> pars)
        {
            var client = GetClient();
            var myContent = JsonConvert.SerializeObject(pars);

            var response = await client.PostAsync(url,
                new StringContent(myContent, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return;
            }

            var errMsg = await response.Content.ReadAsStringAsync();
            throw new BadRequestException(response.ReasonPhrase + ": " + errMsg);
        }

        public async Task<T> Post<T>(string url, Dictionary<string, object> pars)
        {
            var client = GetClient();
            var myContent = JsonConvert.SerializeObject(pars);

            var response = await client.PostAsync(url,
                new StringContent(myContent, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsAsync<T>();
                return res;
            }

            var errMsg = await response.Content.ReadAsStringAsync();
            throw new BadRequestException(response.ReasonPhrase + ": " + errMsg);
        }

        public async Task<T> Get<T>(string url, Dictionary<string, object> pars)
        {
            var sb = new StringBuilder();
            if (pars.Count > 0)
            {
                sb.Append("?");
            }

            var first = true;
            foreach (var pair in pars)
            {
                if (pair.Value != null)
                {
                    if (!first)
                    {
                        sb.Append("&");
                    }
                    sb.Append($@"{pair.Key}={pair.Value.ToString()}");
                }

                first = false;
            }

            return await Get<T>(url + sb);
        }

        public async Task<T> Get<T>(string url)
        {
            var client = GetClient();

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var res = await response.Content.ReadAsAsync<T>();
                return res;
            }

            var errMsg = await response.Content.ReadAsStringAsync();
            throw new BadRequestException(response.ReasonPhrase + ": " + errMsg);
        }

    }
}
