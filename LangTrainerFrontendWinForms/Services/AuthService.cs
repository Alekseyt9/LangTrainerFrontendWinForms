
using LangTrainerClientModel.Services;

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

        public async Task<bool> Login(string email, string pass)
        {
            try
            {
                var res = await HttpClientService.GetInstance().Post<TokensAuth>(@"https://localhost:44329/api/Auth/Login",
                    new Dictionary<string, object>()
                    {
                        { "Email", email },
                        { "Password", pass }
                    });
                _tokensAuth = res;
                NotifyService.GetInstance().ShowMessage(res != null ? "Login success" : "Login failed");
                if (res != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message);
            }

            return false;
        }

        public async Task Register(string email, string pass)
        {
            await HttpClientService.GetInstance().Post(@"https://localhost:44329/api/Auth/Register",
                new Dictionary<string, object>()
                {
                    { "Password", pass },
                    { "Email", email }
                });
            NotifyService.GetInstance().ShowMessage("Registration success");
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
                NotifyService.GetInstance().ShowMessage(ex.Message);
            }
        }

    }
}
