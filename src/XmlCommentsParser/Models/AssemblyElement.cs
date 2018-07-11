using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public class AssemblyElement
    {
        [XmlElement(ElementName = "name")] 
        public string Name { get; set; }
    }
}