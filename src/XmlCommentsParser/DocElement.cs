using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlCommentsParser
{
    [XmlRootAttribute("doc")]
    public class DocElement
    {
        [XmlElement(ElementName = "assembly")] 
        public AssemblyElement Assembly { get; set; }
        
        [XmlArrayItem(ElementName= "member", IsNullable=true, Type = typeof(MemberElement))]
        [XmlArrayAttribute("members")]
        public List<MemberElement> Members { get; set; } = new List<MemberElement>();
    }
}