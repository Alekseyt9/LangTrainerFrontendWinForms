
using LangTrainerClientModel.Model.User;

namespace LangTrainerFrontendWinForms.Services
{
    internal class AuthService
    {
        private static AuthService instance;
        private TokensAuth _tokensAuth;

        public AuthService() { }

        public TokensAuth TokensAuth => _tokensAuth;

        public static AuthService GetInstance()
        {
            if (instance == null)
            {
                instance = new AuthService();
            }
            return instance;
        }

        public async Task<bool> Login(string user, string pass)
        {
            try
            {
                var res = await HttpClientService.GetInstance().Post<TokensAuth>(@"https://localhost:44329/api/Auth/Login",
                    new Dictionary<string, object>()
                    {
                        { "Login", user },
                        { "Password", pass }
                    });
                _tokensAuth = res;
                NotifyService.GetInstance().ShowMessage(res != null ? "Login success" : "Login failed", 0.7f);
                if (res != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message, 0.7f);
            }

            return false;
        }

        public async Task Register(string user, string email, string pass)
        {
            try
            {
                await HttpClientService.GetInstance().Post(@"https://localhost:44329/api/Auth/Login",
                    new Dictionary<string, object>()
                    {
                        { "Login", user },
                        { "Password", pass },
                        { "Email", email }
                    });
                NotifyService.GetInstance().ShowMessage("Registration success");
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message, 0.7f);
            }
        }

        public async Task Recovery(string email)
        {
            try
            {
                await HttpClientService.GetInstance().Post(@"https://localhost:44329/api/Auth/Recovery",
                    new Dictionary<string, object>()
                    {
                        { "Email", email }
                    });
                NotifyService.GetInstance().ShowMessage("Email sended");
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message, 0.7f);
            }
        }

    }
}
