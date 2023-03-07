using LangTrainerFrontendWinForms.Service;
using Xunit;

namespace LangTrainerFrontendWinFormsTest
{
    public class LangServiceTest
    {
        [Fact]
        public async void Test()
        {
            var serv = LangService.GetInstance();
            var res = await serv.GetTokenData("data", "english");
            Assert.NotNull(res);
        }

    }
}