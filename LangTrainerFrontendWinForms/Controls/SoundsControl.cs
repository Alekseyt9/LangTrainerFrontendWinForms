
using LangTrainerEntity.Entities.Lang;

namespace LangTrainerFrontendWinForms.Controls
{
    public partial class SoundsControl : UserControl
    {
        public SoundsControl()
        {
            InitializeComponent();
        }

        public void Init(Expression expr)
        {
            _tableLayout.Controls.Clear();
            _tableLayout.ColumnStyles.Clear();
            _tableLayout.ColumnCount = expr.Sounds.Count + 1;

            for (var i = 0; i < _tableLayout.ColumnCount-1; i++)
            {
                _tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                var butCtr = new SoundButton();
                butCtr.Sound = expr.Sounds.ElementAt(i).Data;
                _tableLayout.Controls.Add(butCtr);
                _tableLayout.SetCellPosition(butCtr, new TableLayoutPanelCellPosition(i, 0));
            }

            _tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
            var addCtr = new AddSoundButton();
            _tableLayout.Controls.Add(addCtr);
            _tableLayout.SetCellPosition(addCtr, 
                new TableLayoutPanelCellPosition(_tableLayout.ColumnCount-1, 0));

        }

    }
}
