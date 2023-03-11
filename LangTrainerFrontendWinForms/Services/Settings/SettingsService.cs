
using System.Configuration;
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

        public Settings GetServerSettings()
        {
            throw new NotImplementedException();
        }

        public void SaveRemoteSettings(Settings settings)
        {

        }

    }
}
