using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public abstract class XmlCodeCommentFormattableElement
    {
        [XmlText]
        public string Value { get; set; }
    }
}