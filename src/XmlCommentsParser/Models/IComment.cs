namespace XmlCommentsParser.Models
{
    public interface IComment
    {
        string Name { get; set; }
        SourceObjectType SourceObjectType { get; set; }
        string Example { get; set; }
        string Summary { get; set; }
        string Remarks { get; set; }
        string Returns { get; set; }
        string Value { get; set; }
    }
}