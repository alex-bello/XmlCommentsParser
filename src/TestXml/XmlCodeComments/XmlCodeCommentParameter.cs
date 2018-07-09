using System.Xml.Serialization;

namespace TestXml.XmlCodeComments
{
    public class XmlCodeCommentParameter
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}