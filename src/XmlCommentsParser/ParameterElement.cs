using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public class ParameterElement
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}