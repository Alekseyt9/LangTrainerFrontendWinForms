
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Model
{
    internal interface ISettingsСonsumer
    {
        void InitSettings(Settings settings, string parentKey);

        void SaveSettings(Settings settings, string parentKey);
    }

}
