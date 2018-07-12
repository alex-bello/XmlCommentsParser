namespace XmlCommentsParser
{
    public interface IComment
    {
        string Name { get; set; }

        SourceObjectType SourceObjectType { get; set; }

        string Example { get; set; }

        ExceptionComment[] Exceptions { get; set; }

        ParameterComment[] Parameters { get; set; }

        string Summary { get; set; }

        string Remarks { get; set; }

        string Returns { get; set; }

        ParameterComment[] TypeParameters { get; set; }

        string Value { get; set; }
    }
}