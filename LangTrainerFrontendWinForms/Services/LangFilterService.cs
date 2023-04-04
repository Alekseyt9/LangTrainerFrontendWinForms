
using LangTrainerEntity.Entities;
using LangTrainerFrontendWinForms.Controls;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Service;

namespace LangTrainerFrontendWinForms.Services
{
    internal class LangFilterService : ISettingsСonsumer
    {
        private ToolStripMenuItem _optItem;
        private Guid? _trlangId;
        private Guid? _langId;
        private bool _inChange;

        public event EventHandler Changed;
        public event EventHandler Loaded;

        public FilterData Filter =>
            new()
            {
                LangId = _langId,
                TrLangId = _trlangId
            };

        private static LangFilterService _instance;

        private LangFilterService() { }

        public bool IsLoaded => _langId.HasValue && _trlangId.HasValue;

        public void Init(Form form, ToolStripMenuItem optItem)
        {
            _optItem = optItem;

            AsyncHelper.DoAsync(optItem, () =>
                {
                    var res = LangService.GetInstance().GetLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
                    if (data == null)
                        return;
                    
                    form.Invoke(() =>
                    {
                        InitLang(data, "languageToolStripMenuItem", _langId);
                    });

                    if (IsLoaded)
                    {
                        Loaded?.Invoke(this, EventArgs.Empty);
                    }
                }
            );

            AsyncHelper.DoAsync(optItem, () =>
                {
                    var res = LangService.GetInstance().GetTranslateLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
                    if (data == null)
                        return;

                    form.Invoke(() =>
                    {
                        InitLang(data, "translateLanguageToolStripMenuItem", _trlangId);
                    });

                    if (IsLoaded)
                    {
                        Loaded?.Invoke(this, EventArgs.Empty);
                    }
                }
            );
        }

        private void InitLang(List<Language> langData, string key, Guid? langId)
        {
            var langItem = GetItem(key);
            langItem.DropDownItems.Clear();

            _inChange = true;
            foreach (var item in langData)
            {
                var menuItem = new ToolStripMenuItem(item.Name);
                menuItem.Tag = item;
                menuItem.CheckOnClick = true;
                menuItem.Name = item.Name;

                if (langId == item.Id)
                {
                    menuItem.Checked = true;
                }

                _inChange = false;
                menuItem.CheckedChanged += MenuItem_CheckedChanged;
                langItem.DropDownItems.Add(menuItem);
            }

            _inChange = false;
        }

        private void MenuItem_CheckedChanged(object? sender, EventArgs e)
        {
            var cur = (ToolStripMenuItem)sender;
            if (!_inChange)
            {
                var parent = (ToolStripMenuItem)cur.OwnerItem;

                _inChange = true;
                foreach (ToolStripMenuItem item1 in parent.DropDownItems)
                {
                    item1.Checked = false;
                }
                cur.Checked = true;
                _inChange = false;

                if (parent.Name == "languageToolStripMenuItem")
                {
                    _langId = ((Language)cur.Tag).Id;
                }
                if (parent.Name == "translateLanguageToolStripMenuItem")
                {
                    _trlangId = ((Language)cur.Tag).Id;
                }

                Changed?.Invoke(this, EventArgs.Empty);
            }
        }

        private ToolStripMenuItem GetItem(string key)
        {
            return (ToolStripMenuItem)_optItem.DropDownItems.Find(key, false)[0];
        }

        public static LangFilterService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LangFilterService();
            }
            return _instance;
        }

        public void InitSettings(Settings settings, string parentKey)
        {
            _langId = settings.Get<Guid?>(SettingsKeys.DictionaryFilterLangId);
            _trlangId = settings.Get<Guid?>(SettingsKeys.DictionaryFilterTrLangId);
        }

        public void SaveSettings(Settings settings, string parentKey)
        {
            settings.Set(SettingsKeys.DictionaryFilterLangId, _langId);
            settings.Set(SettingsKeys.DictionaryFilterTrLangId, _trlangId);
        }

    }
}
