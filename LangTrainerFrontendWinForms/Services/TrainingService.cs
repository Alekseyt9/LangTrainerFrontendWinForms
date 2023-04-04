

namespace LangTrainerFrontendWinForms.Services
{
    internal class TrainingService
    {
        private static TrainingService _instance;

        private TrainingService() { }

        public static TrainingService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TrainingService();
            }
            return _instance;
        }

        public async Task AddToTraining(Guid translateId)
        {
            await HttpClientService.GetInstance().Post(
                @"https://localhost:44329/api/Training/AddTranslateToTraining",
                new Dictionary<string, object>()
                {
                    { "translateId", translateId }
                });
        }

    }
}
