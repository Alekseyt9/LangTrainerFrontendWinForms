
using System.Xml.Serialization;

namespace LangTrainerFrontendWinForms.Model
{
    public class ButtonCoordinates
    {
        [XmlAttribute("Code")]
        public string Code { get; set; }


        [XmlAttribute("Text")]
        public string Text { get; set; }

        [XmlAttribute("X")]
        public int X { get; set; }


        [XmlAttribute("Y")]
        public int Y { get; set; }


        [XmlAttribute("W")]
        public int W { get; set; }


        [XmlAttribute("H")]
        public int H { get; set; }

    }

}
