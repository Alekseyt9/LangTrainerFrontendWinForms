
using LangTrainerCommon.Helpers;

namespace LangTrainerFrontendWinForms
{
    public partial class FormComboTest : Form
    {
        public FormComboTest()
        {
            InitializeComponent();

            //comboBox1.Items.Clear();
            //comboBox1.Items.Add("");
            //comboBox1.Items.Add("");
            comboBox1.Items.Add("Текст 3\nВторая строка\nТретья строка");
            //comboBox1.Items.Add("Текст 3\nВторая строка\nТретья строка");
            //comboBox1.Items.Add("Текст 3\nВторая строка\nТретья строка");

            //comboBox1.IntegralHeight = false;
            //comboBox1.DropDownHeight = 400;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //comboBox1.Items.Add(
            //    StringHelper.SplitStringByLength("ewg uhwefv jwevjfvvwegvfghwevfg vwev fvwegv fgvwegv fgvwegfv gwevfg wev fvwe", 50));
            //comboBox1.Items.Add("");
            //comboBox1.Mi

            //comboBox1.Items.Add("Текст 1");
            /*
            comboBox1.Items.Add("Текст 2\nВторая строка");
            comboBox1.Items.Add("Текст 3\nВторая строка\nТретья строка");
            comboBox1.Items.Add("Текст 4");
            comboBox1.Items.Add("Текст 5");
            */
        }
    }
}
