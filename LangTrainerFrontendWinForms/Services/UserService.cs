
using LangTrainerClientModel.Model.User;
using LangTrainerCommon.Helpers;

namespace LangTrainerFrontendWinForms.Services
{
    internal class UserService
    {
        private static UserService instance;
        private TokensAuth _tokensAuth;

        public UserService() { }

        public TokensAuth TokensAuth { get {  return _tokensAuth; } }

        public static UserService GetInstance()
        {
            if (instance == null)
            {
                instance = new UserService();
            }
            return instance;
        }

        public async Task<bool> Login(string user, string pass)
        {
            try
            {
                var res = await HttpClientService.GetInstance().Post<TokensAuth>(@"https://localhost:44329/api/User/Login",
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

    }
}
