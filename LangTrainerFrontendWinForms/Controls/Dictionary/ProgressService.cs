

namespace LangTrainerFrontendWinForms.Controls.Dictionary
{
    internal class ProgressService
    {
        private ProgressBar _progressBar;
        private int _counter = 0;

        public ProgressService(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }

        public void Switch(bool flag)
        {
            if (flag)
            {
                _counter++;
            }
            else
            {
                if (_counter > 0)
                    _counter--;
            }

            if (_counter > 0)
            {
                _progressBar.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                _progressBar.Style = ProgressBarStyle.Continuous;
            }
        }

    }

}
