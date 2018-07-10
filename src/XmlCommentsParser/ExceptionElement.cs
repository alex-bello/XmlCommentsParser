using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public class ExceptionElement
    {
        [XmlAttribute(AttributeName = "member")]
        public string Member { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}