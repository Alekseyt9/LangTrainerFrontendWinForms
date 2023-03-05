
using LangTrainerFrontendWinForms.Controllers;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Model;
using LangTrainerFrontendWinForms.Service;

namespace LangTrainerFrontendWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Load += FormMainLoad;
            KeyPreview = true;
            KeyDown += FormMainKeyDown;
            _tabControl.HideHeader();

            _tabControl.SetPage("dictionaryPage");
        }

        private void FormMainKeyDown(object? sender, KeyEventArgs e)
        {

        }

        private async void FormMainLoad(object? sender, EventArgs e)
        {
            var model = GetModel();
            var ctr = new MainController(tabControl1, model);
            ctr.Next();
        }

        private async Task InitEditFormTest()
        {
            var serv = new LangService();
            var expr = await serv.GetTokenData("data", "english");
            sentenceEditControl1.InitForm(expr);
        }

        private TrainingModel GetModel()
        {
            return new TrainingModel()
            {
                Model1 = new Excercize1Model()
                {
                    Answer = "lure",
                    Question = "the quality or power that something or someone has that makes it, him, or her attractive",
                    Variants = new[] { "lurk", "bury", "litter", "lure" }
                }
            };
        }

        private void dictionaryMenuItemClick(object sender, EventArgs e)
        {
            _tabControl.SetPage("dictionaryPage");
        }

        private void trainingMenuItemClick(object sender, EventArgs e)
        {
            _tabControl.SetPage("trainerPage");
        }

        private void tasksMenuItem1Click(object sender, EventArgs e)
        {
            _tabControl.SetPage("taskPage");
        }

    }
}