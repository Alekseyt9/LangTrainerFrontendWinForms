
using LangTrainerClientModel.Model.User;
using LangTrainerCommon.Helpers;

namespace LangTrainerFrontendWinForms.Services
{
    internal class UserService
    {
        private static UserService instance;

        public UserService() { }

        public static UserService GetInstance()
        {
            if (instance == null)
            {
                instance = new UserService();
            }
            return instance;
        }

        public async Task Login(string user, string pass)
        {
            try
            {
                var res = await WebClientHelper.Post<TokensAuth>(@"https://localhost:44329/api/User/Login",
                    new Dictionary<string, object>()
                    {
                        { "Name", user },
                        { "Password", pass }
                    });

                NotifyService.GetInstance().ShowMessage(res != null ? "Login success" : "Login failed", 0.7f);
            }
            catch (Exception ex)
            {
                NotifyService.GetInstance().ShowMessage(ex.Message, 0.7f);
            }

        }

    }
}
