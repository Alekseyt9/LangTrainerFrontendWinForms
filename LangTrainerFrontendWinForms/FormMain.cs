
using LangTrainerClientModel.Model;
using LangTrainerClientModel.Model.Training;
using LangTrainerFrontendWinForms.Controls.Training.ExStart;
using LangTrainerFrontendWinForms.Helpers;
using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            NotifyService.GetInstance().Init(this, toolTip1);

            Load += FormMainLoad;
            KeyPreview = true;
            KeyDown += FormMainKeyDown;

            _tabControl.HideHeader();

            //_tabControl.SetPage("dictionaryPage");
            _tabControl.SetPage("loginPage");
        }

        private void FormMainKeyDown(object? sender, KeyEventArgs e)
        {

        }

        private async void FormMainLoad(object? sender, EventArgs e)
        {
            TrainerTest();
        }

        /*
        private async Task InitEditFormTest()
        {
            var serv = new LangService();
            var expr = await serv.GetTokenData("data", "english");
            sentenceEditControl1.InitForm(expr);
        }
        */

        private void TrainerTest()
        {
            InitStartPage();
            InitExs();
        }

        private void InitExs()
        {
            /*
            var model = GetTrainingModel();
            var ctr = new MainController(tabControl1, model);
            ctr.Next();
            */
        }

        private void InitStartPage()
        {
            var model = new StartTrainingModel()
            {
                Maturation = new StartTrainingItem()
                {
                    Count = 111,
                    Words = new List<string>() { "aaa", "bbb" }
                },
                New = new StartTrainingItem()
                {
                    Count = 222,
                    Words = new List<string>() { "ggg", "hhh" }
                },
                Repeat = new StartTrainingItem()
                {
                    Count = 333,
                    Words = new List<string>() { "ooo", "ppp" }
                },
            };

            var startTrCtr = this.Find<ExStartControl>().First();
            startTrCtr.Init(model);
        }

        private TrainingModel GetTrainingModel()
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

        private void DictionaryMenuItemClick(object sender, EventArgs e)
        {
            _tabControl.SetPage("dictionaryPage");
        }

        private void TrainingMenuItemClick(object sender, EventArgs e)
        {
            _tabControl.SetPage("trainerPage");
        }

        private void TasksMenuItem1Click(object sender, EventArgs e)
        {
            _tabControl.SetPage("taskPage");
        }

        private void wordListMenuItem_Click(object sender, EventArgs e)
        {
            _tabControl.SetPage("wordListPage");
        }

        private void toolTipTestMenuItem_Click(object sender, EventArgs e)
        {
            NotifyService.GetInstance().ShowMessage("Test");
        }

    }
}