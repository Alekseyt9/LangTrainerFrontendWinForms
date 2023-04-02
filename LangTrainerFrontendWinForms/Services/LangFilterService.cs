
using LangTrainerEntity.Entities;
using LangTrainerFrontendWinForms.Controls.Common;
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

        public FilterData Filter =>
            new()
            {
                LangId = _langId,
                TrLangId = _trlangId
            };

        private static LangFilterService _instance;

        private LangFilterService() { }

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
                        InitLang(data, "languageToolStripMenuItem");
                    });
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
                        InitLang(data, "translateLanguageToolStripMenuItem");
                    });
                }
            );
        }

        private void InitLang(List<Language> langData, string key)
        {
            var langItem = GetItem(key);
            langItem.DropDownItems.Clear();
            
            foreach (var item in langData)
            {
                var menuItem = new ToolStripMenuItem(item.Name);
                menuItem.Tag = item;
                menuItem.CheckOnClick = true;
                menuItem.Name = item.Name;

                if (_trlangId == item.Id)
                {
                    menuItem.Checked = true;
                }

                _inChange = false;
                menuItem.CheckedChanged += MenuItem_CheckedChanged;
                langItem.DropDownItems.Add(menuItem);
            }
        }

        private void MenuItem_CheckedChanged(object? sender, EventArgs e)
        {
            var cur = (ToolStripMenuItem)sender;
            if (!_inChange)
            {
                _inChange = true;
                foreach (ToolStripMenuItem item1 in ((ToolStripMenuItem)cur.OwnerItem).DropDownItems)
                {
                    item1.Checked = false;
                }
                cur.Checked = true;
                _inChange = false;
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
