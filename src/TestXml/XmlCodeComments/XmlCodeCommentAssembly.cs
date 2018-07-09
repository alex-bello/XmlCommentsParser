using System.Xml.Serialization;

namespace TestXml.XmlCodeComments
{
    public class XmlCodeCommentAssembly
    {
        [XmlElement(ElementName = "name")] 
        public string Name { get; set; }
    }
}