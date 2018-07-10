using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlCommentsParser
{
    [XmlRootAttribute("doc")]
    public class DocElement
    {
        [XmlElement(ElementName = "assembly")] 
        public AssemblyElement Assembly { get; set; }
        
        [XmlArrayItem(ElementName= "member", IsNullable=true, Type = typeof(MemberXmlElement))]
        [XmlArrayAttribute("members")]
        public List<MemberXmlElement> Members { get; set; } = new List<MemberXmlElement>();
    }
}