using System;
using System.Windows.Forms;

namespace LangTrainerFrontendWinForms.Controls.Out.Accordion
{

    public interface IToolTips : IDisposable
    {
        void Add(Control control, string text);
        void Batch(Control control, string text);
        void ApplyBatched();
        void RemoveAll();
    }
}