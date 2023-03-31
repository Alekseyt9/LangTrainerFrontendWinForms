
using System.Collections.Generic;
using LangTrainerClientModel.Model;
using System.Configuration;
using System.Threading.Tasks;
using static System.Configuration.ConfigurationSettings;

namespace LangTrainerFrontendWinForms.Services
{
    public class SettingsService
    {
        private static SettingsService _instance;

        private SettingsService() { }

        public static SettingsService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SettingsService();
            }
            return _instance;
        }

        public Settings GetLocalSettings()
        {
            var cfg = new Settings();
            var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            foreach (var key in config.AppSettings.Settings.AllKeys)
            {
                cfg.Set(key, config.AppSettings.Settings[key].Value);
            }

            return cfg;
        }

        public void SaveLocalSettings(Settings settings)
        {
            var config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            foreach (var key in settings.GetKeys())
            {
                if (config.AppSettings.Settings[key] == null)
                {
                    config.AppSettings.Settings.Add(key, null);
                }
                config.AppSettings.Settings[key].Value = settings.Get(key).ToString();
            }

            config.Save(ConfigurationSaveMode.Modified);
        }

        public async Task<Settings> GetRemoteSettings()
        {
            var vals = await HttpClientService.GetInstance().Get<SettingsValues>(
                @"https://localhost:44329/api/Settings/GetSettings");
            return new Settings(vals);
        }

        public async Task SaveRemoteSettings(Settings settings)
        {
            await HttpClientService.GetInstance().Post(
                @"https://localhost:44329/api/Settings/SetSettings", 
                new Dictionary<string, object>() {{"data", settings.GetSettingsValues()} }
                );
        }

    }
}
