

namespace LangTrainerFrontendWinForms.Services
{
    public class Settings
    {
        private readonly Dictionary<string, object> _data = new();

        public void Set<T>(string key, T value)
        {
            _data[key] = value;
        }

        public T Get<T>(string key)
        {
            if (_data.ContainsKey(key))
            {
                return (T)_data[key];
            }

            return default;
        }

        public void Set(string key, object value)
        {
            _data.Add(key, value);
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

    }
}
