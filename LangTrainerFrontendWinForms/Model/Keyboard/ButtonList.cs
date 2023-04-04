
using System.Xml.Serialization;

namespace LangTrainerFrontendWinForms.Model
{
    [XmlRoot("Buttons")]
    public class ButtonList
    {
        [XmlElement("Button")]
        public List<ButtonCoordinates> Buttons { get; set; }
    }
}
