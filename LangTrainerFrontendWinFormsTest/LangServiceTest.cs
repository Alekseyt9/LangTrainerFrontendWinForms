using LangTrainerFrontendWinForms.Service;
using Xunit;

namespace LangTrainerFrontendWinFormsTest
{
    public class LangServiceTest
    {
        [Fact]
        public async void Test()
        {
            var serv = new LangService();
            var res = await serv.GetTokenData("data", "english");
            Assert.NotNull(res);
        }

    }
}