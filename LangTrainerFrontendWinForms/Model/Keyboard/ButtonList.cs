
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Oskeyboard.Serialize
{
    [XmlRoot("Buttons")]
    public class ButtonList
    {
        [XmlElement("Button")]
        public List<ButtonCoordinates> Buttons { get; set; }
    }
}
