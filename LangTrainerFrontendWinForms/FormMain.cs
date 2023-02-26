
using LangTrainerFrontendWinForms.Controllers;
using LangTrainerFrontendWinForms.Model;
using System.Windows.Forms;

namespace LangTrainerFrontendWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            /*
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.SelectedIndex = 2;
            */

            Load += FormMainLoad;

            KeyPreview = true;
            KeyDown += FormMainKeyDown;
        }

        private void FormMainKeyDown(object? sender, KeyEventArgs e)
        {

        }

        private void FormMainLoad(object? sender, EventArgs e)
        {
            var model = GetModel();
            var ctr = new MainController(tabControl1, model);
            ctr.Next();
        }

        private MainModel GetModel()
        {
            return new MainModel()
            {
                Model1 = new Excercize1Model()
                {
                    Answer = "lure",
                    Question = "the quality or power that something or someone has that makes it, him, or her attractive",
                    Variants = new[] { "lurk", "bury", "litter", "lure" }
                }
            };
        }

    }
}