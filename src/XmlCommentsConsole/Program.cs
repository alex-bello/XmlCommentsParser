using System;
using XmlCommentsParser;

namespace XmlCommentsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"c:\temp\TestDoc.xml";
            XmlComments.Parse(file);
        }
    }
}
