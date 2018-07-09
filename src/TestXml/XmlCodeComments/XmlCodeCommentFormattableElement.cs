using System.Xml.Serialization;

namespace TestXml.XmlCodeComments
{
    public abstract class XmlCodeCommentFormattableElement
    {
        [XmlText]
        public string Value { get; set; }
    }
}