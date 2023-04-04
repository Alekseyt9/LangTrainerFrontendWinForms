using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Service;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class LangFilter : UserControl, ISettingsСonsumer
    {
        private Guid? _initialFilterLangId;
        private Guid? _initialFilterTrLangId;

        public event EventHandler LangChanged;

        public FilterData Data
        {
            get
            {
                var res = new FilterData();
                if (_langFilterCombo.SelectedItem != null)
                {
                    res.LangId = (Guid?)((ComboboxItem)_langFilterCombo.SelectedItem).Value;
                }
                if (_trLangFilterCombo.SelectedItem != null)
                {
                    res.LangId = (Guid?)((ComboboxItem)_trLangFilterCombo.SelectedItem).Value;
                }

                return res;
            }
        }

        public LangFilter()
        {
            InitializeComponent();
        }

        public void Init()
        {
            AsyncHelper.DoAsync(_langFilterCombo, () =>
                {
                    var res = LangService.GetInstance().GetLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
                    if (data == null)
                    {
                        return;
                    }
                    Invoke(() =>
                    {
                        ctr.Items.Clear();
                        foreach (var item in data)
                        {
                            ctr.Items.Add(new ComboboxItem()
                            {
                                Text = item.Name,
                                Value = item.Id
                            });
                        }
                        InitFilters();
                    });
                }
            );

            AsyncHelper.DoAsync(_trLangFilterCombo, () =>
                {
                    var res = LangService.GetInstance().GetTranslateLanguages().Result;
                    return res;
                },
                (ctr, data) =>
                {
                    if (data == null)
                    {
                        return;
                    }
                    Invoke(() =>
                    {
                        ctr.Items.Clear();
                        foreach (var item in data)
                        {
                            ctr.Items.Add(new ComboboxItem()
                            {
                                Text = item.Name,
                                Value = item.Id
                            });
                        }
                        InitFilters();
                    });
                }
            );
        }

        private void InitFilters()
        {
            if (_initialFilterLangId.HasValue && _langFilterCombo.Items.Count > 0)
            {
                var item = _langFilterCombo.Items.Cast<ComboboxItem>()
                    .First(x => (Guid)x.Value == _initialFilterLangId);
                _langFilterCombo.SelectedItem = item;
            }

            if (_initialFilterTrLangId.HasValue && _trLangFilterCombo.Items.Count > 0)
            {
                var item = _trLangFilterCombo.Items.Cast<ComboboxItem>()
                    .First(x => (Guid)x.Value == _initialFilterTrLangId);
                _trLangFilterCombo.SelectedItem = item;
            }
        }

        public void InitSettings(Settings settings, string parentKey)
        {
            _initialFilterLangId = settings.Get<Guid?>(
                parentKey + "_" + SettingsKeys.DictionaryFilterLangId);
            _initialFilterTrLangId = settings.Get<Guid?>(
                parentKey + "_" + SettingsKeys.DictionaryFilterTrLangId);
            InitFilters();
        }

        public void SaveSettings(Settings settings, string parentKey)
        {
            if (_langFilterCombo.SelectedItem != null)
            {
                var item = (ComboboxItem)_langFilterCombo.SelectedItem;
                settings.Set(parentKey + "_" + SettingsKeys.DictionaryFilterLangId, item.Value);
            }

            if (_trLangFilterCombo.SelectedItem != null)
            {
                var item = (ComboboxItem)_trLangFilterCombo.SelectedItem;
                settings.Set(parentKey + "_" + SettingsKeys.DictionaryFilterTrLangId, item.Value);
            }
        }

        private void _langFilterCombo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_langFilterCombo.SelectedItem == null)
            {
                errorProvider1.SetError(_langFilterCombo, "not null");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void _langFilterCombo_Enter(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void _langFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateChildren();
            LangChanged?.Invoke(this, EventArgs.Empty);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripDropDownItem;
            if (item == null) // Error
                return;
            var strip = item.Owner as ContextMenuStrip;
            var obj = strip.SourceControl as ComboBox;
            obj.SelectedIndex = -1;
        }

    }
}
