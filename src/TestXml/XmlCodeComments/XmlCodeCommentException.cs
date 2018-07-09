using System.Xml.Serialization;

namespace TestXml.XmlCodeComments
{
    public class XmlCodeCommentException
    {
        [XmlAttribute(AttributeName = "member")]
        public string Member { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}