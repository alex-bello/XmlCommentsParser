using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public abstract class FormattableElement
    {
        [XmlText]
        public string Value { get; set; }
    }
}