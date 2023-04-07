
using System.Drawing.Drawing2D;
using System.Xml.Serialization;
using LangTrainerFrontendWinForms.Model;

namespace LangTrainerFrontendWinForms
{
    public partial class FormKeyboardTest : Form
    {
        private readonly List<ButtonCoordinates> _rectangles;
        private int hoveredRectangleIndex = -1;
        private readonly HashSet<int> _keysPress = new();

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public FormKeyboardTest()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            _rectangles = DeserializeButtonCoordinates("keyboard.xml").Buttons;
            MouseMove += MainForm_MouseMove;
            Resize += MainForm_Resize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            var newHoveredRectangleIndex = -1;

            var scaleFactor = GetScaleFactor();
            for (var i = 0; i < _rectangles.Count; i++)
            {
                var rectangleInfo = _rectangles[i];
                var rectangle = new Rectangle((int)(rectangleInfo.X * scaleFactor),
                    (int)(rectangleInfo.Y * scaleFactor), (int)(rectangleInfo.W * scaleFactor), (int)(rectangleInfo.H * scaleFactor));

                if (rectangle.Contains(e.Location))
                {
                    newHoveredRectangleIndex = i;
                    break;
                }
            }

            if (newHoveredRectangleIndex != hoveredRectangleIndex)
            {
                hoveredRectangleIndex = newHoveredRectangleIndex;
                Invalidate();
            }
        }

        public ButtonList DeserializeButtonCoordinates(string filePath)
        {
            var serializer = new XmlSerializer(typeof(ButtonList));
            using var reader = new StreamReader(filePath);
            return (ButtonList)serializer.Deserialize(reader);
        }

        private float GetScaleFactor()
        {
            return Math.Min((float)ClientSize.Width / 900, (float)ClientSize.Height / 400);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var graphics = e.Graphics;
            var pen = new Pen(Color.Black);
            var scaleFactor = GetScaleFactor();
            Brush textBrush = new SolidBrush(Color.Black);
            var cornerRadius = (int)(15 * scaleFactor);

            using Brush greenBrush = new SolidBrush(Color.Green);
            using Brush grayBrush = new SolidBrush(Color.LightGray);
            using Brush blueBrush = new SolidBrush(Color.CornflowerBlue);

            for (var i = 0; i < _rectangles.Count; i++)
            {
                var rInfo = _rectangles[i];

                var rectangle = new Rectangle((int)(rInfo.X * scaleFactor),
                    (int)(rInfo.Y * scaleFactor), (int)(rInfo.W * scaleFactor), (int)(rInfo.H * scaleFactor));

                using (var path = new GraphicsPath())
                {
                    AddRoundedRectangle(path, rectangle, cornerRadius);
                    if (!string.IsNullOrEmpty(rInfo.Code) && _keysPress.Contains(int.Parse(rInfo.Code)))
                    {
                        graphics.FillPath(blueBrush, path);
                    }
                    else
                    {
                        graphics.FillPath(i == hoveredRectangleIndex ? greenBrush : grayBrush, path);
                    }
                    
                    graphics.DrawPath(pen, path);
                }

                var fontSize = 12 * scaleFactor;
                var font = new Font("Arial", fontSize);
                var text = rInfo.Text;
                var textSize = graphics.MeasureString(text, font);

                // Уменьшение размера шрифта, если текст не вмещается в прямоугольник
                while (textSize.Width > rectangle.Width || textSize.Height > rectangle.Height)
                {
                    fontSize -= 0.5f;
                    font = new Font("Arial", fontSize);
                    textSize = graphics.MeasureString(text, font);
                }

                var x = rInfo.X * scaleFactor + (rInfo.W * scaleFactor - textSize.Width) / 2;
                var y = rInfo.Y * scaleFactor + (rInfo.H * scaleFactor - textSize.Height) / 2;
                graphics.DrawString(text, font, textBrush, x, y);
            }

            void AddRoundedRectangle(GraphicsPath path, Rectangle rect, int cornerRadius)
            {
                var x = rect.X;
                var y = rect.Y;
                var width = rect.Width;
                var height = rect.Height;

                path.AddArc(x, y, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(x + width - cornerRadius, y, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(x + width - cornerRadius, y + height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(x, y + height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();
            }

        }

        private void FormKeyboardTest_KeyDown(object sender, KeyEventArgs e)
        {
            _keysPress.Add(e.KeyValue);
            Invalidate();
        }

        private void FormKeyboardTest_KeyUp(object sender, KeyEventArgs e)
        {
            _keysPress.Remove(e.KeyValue);
            Invalidate();
        }

    }
}
