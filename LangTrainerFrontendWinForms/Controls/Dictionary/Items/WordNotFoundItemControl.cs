
using LangTrainerFrontendWinForms.Controls.Dictionary.Items;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Service;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class WordNotFoundItemControl : UserControl
    {
        private string _word;

        public EventHandler<OnLoadWordEventArgs> OnLoadWordClick;

        public WordNotFoundItemControl()
        {
            InitializeComponent();
        }

        public void Init(string str)
        {
            AsyncHelper.DoAsync(_languageCombo, () =>
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
                        foreach (var lang in data)
                        {
                            _languageCombo.Items.Add(new ComboboxItem()
                            {
                                Text = lang.Name,
                                Value = lang.Id
                            });
                        }
                    });
                }
            );

            _word = str;
            _label.Text = $"Word '{_word}' not found in database";
        }

        private void loadButtonClick(object sender, EventArgs e)
        {
            if (OnLoadWordClick != null)
            {
                if (_languageCombo.SelectedIndex < 0)
                {
                    return;
                }

                var item = (ComboboxItem)_languageCombo.Items[_languageCombo.SelectedIndex];
                OnLoadWordClick(this, new OnLoadWordEventArgs()
                {
                    LanguageId = (Guid)item.Value,
                    Word = _word
                });
            }
        }

    }
}
