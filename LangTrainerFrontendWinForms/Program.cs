namespace LangTrainerFrontendWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm2());
            //Application.Run(new FormComboTest());
        }
    }
}