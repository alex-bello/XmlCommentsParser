using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestXml.XmlCodeComments
{
    [XmlRootAttribute("doc")]
    public class XmlCodeCommentDoc
    {
        [XmlElement(ElementName = "assembly")] 
        public XmlCodeCommentAssembly Assembly { get; set; }
        
        [XmlArrayItem(ElementName= "member", IsNullable=true, Type = typeof(XmlCodeCommentMember))]
        [XmlArrayAttribute("members")]
        public List<XmlCodeCommentMember> Members { get; set; } = new List<XmlCodeCommentMember>();
    }
}