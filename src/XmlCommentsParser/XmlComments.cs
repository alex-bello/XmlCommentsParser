using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using XmlCommentsParser;

namespace XmlCommentsParser
{
    public static class XmlComments
    {
        public static DocElement Parse(string file)
        {
            var serializer = new XmlSerializer(typeof(DocElement));
            StreamReader reader = new StreamReader(file);
            var docs = (DocElement)serializer.Deserialize(reader);
            reader.Close();
            return docs;
        }

        public static IEnumerable<IComment> GetComments(string file)
        {
            var output = new List<IComment>();
            var docs = XmlComments.Parse(file);

            docs.Members.ForEach(x => {
                var name = x.Name.Split(':');
                output.Add( new Comment { 
                    Name = name[1], 
                    SourceObjectType = GetSourceObjectType(name[0]),
                    Example = x.Example?.InnerXml,
                    Exceptions = x.Exceptions?.Select(y => new ExceptionComment { ExceptionType = y.GetAttribute("cref"), Value = y.InnerXml }).ToArray(),
                    Parameters = x.Parameters?.Select(y => new ParameterComment { Name = y.GetAttribute("name"), Value = y.InnerXml }).ToArray(),
                    Summary = x.Summary?.InnerXml,
                    Remarks = x.Remarks?.InnerXml,
                    Returns = x.Returns?.InnerXml,
                    TypeParameters = x.TypeParameters?.Select(y => new ParameterComment { Name = y.GetAttribute("name"), Value = y.InnerXml }).ToArray(),
                    Value = x.Value?.InnerXml
                    });
            });

            return output;
        }

        private static SourceObjectType GetSourceObjectType(string typeAbbreviation)
        {
            switch (typeAbbreviation)
            {
                case "M":
                    return SourceObjectType.Method;
                case "P":
                    return SourceObjectType.Property;
                case "T":
                    return SourceObjectType.Type;
                default:
                    return SourceObjectType.Unknown;
            }
        }
    }
}
