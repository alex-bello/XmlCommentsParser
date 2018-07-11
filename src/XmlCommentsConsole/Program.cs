using System;
using System.IO;
using System.Linq;
using System.Text;
using XmlCommentsParser;

namespace XmlCommentsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"c:\temp\Health.xml";
            var comments = XmlComments.GetComments(file);

            var output = new StringBuilder();

            comments.ToList().ForEach(x => {
                
                output.AppendLine($"{x.Name}");
                output.AppendLine($"  Type: {x.SourceObjectType.ToString()}");
                x.TypeParameters?.ToList().ForEach(p => output.AppendLine($"  TypeParameter {p.Name}: {p.Value}"));
                x.Parameters?.ToList().ForEach(p => output.AppendLine($"  Parameter {p.Name}: {p.Value}"));
                x.Exceptions?.ToList().ForEach(p => output.AppendLine($"  Exception {p.ExceptionType}: {p.Value}"));
                output.AppendLine($"  Summary: {x.Summary ?? "null"}");
                output.AppendLine($"  Returns: {x.Returns ?? "null"}");
                output.AppendLine($"  Remarks: {x.Remarks ?? "null"}");
                output.AppendLine($"  Example: {x.Example ?? "null"}");
                output.AppendLine($"  Value: {x.Value ?? "null"}");
            });

            File.WriteAllText(@"c:\temp\output_file.txt", output.ToString());
        }
    }
}
