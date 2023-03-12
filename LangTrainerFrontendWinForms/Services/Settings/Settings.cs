

using LangTrainerClientModel.Model;
using LangTrainerClientModel.Model.Settings;

namespace LangTrainerFrontendWinForms.Services
{
    public class Settings
    {
        private readonly Dictionary<string, string> _data = new();

        public Settings()
        {
        }

        public Settings(SettingsValues values)
        {
            foreach (var item in values.Items
                         .Where(x => !string.IsNullOrEmpty(x.Key)  && !string.IsNullOrEmpty(x.Value)))
            {
                _data.Add(item.Key, item.Value);
            }
        }

        public void Set<T>(string key, T value)
        {
            _data[key] = value.ToString();
        }

        public T Get<T>(string key)
        {
            if (_data.ContainsKey(key))
            {
                var val = _data[key];

                var t = typeof(T);
                t = Nullable.GetUnderlyingType(t) ?? t;

                if (typeof(T) == typeof(string))
                    return (T)Convert.ChangeType(val, typeof(T));

                if (typeof(T) == typeof(Guid))
                    return (T)Convert.ChangeType(Guid.Parse(val), typeof(T));

                if (typeof(T) == typeof(Guid?))
                    return (T)Convert.ChangeType(Guid.Parse(val), t);

                throw new NotImplementedException(nameof(T));
            }

            return default;
        }

        public void Set(string key, object value)
        {
            _data[key] = value.ToString();
        }

        public object Get(string key)
        {
            if (_data.ContainsKey(key))
            {
                return _data[key];
            }

            return null;
        }

        public ICollection<string> GetKeys()
        {
            return _data.Keys;
        }

        public SettingsValues GetSettingsValues()
        {
            var res = new SettingsValues();
            foreach (var key in _data.Keys)
            {
                res.Items.Add(new SettingsValue(key, _data[key]));
            }
            return res;
        }

    }
}
