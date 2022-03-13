namespace AntlrExample;

public sealed class TestListener : CSharpParserBaseListener
{
    private readonly Dictionary<string, int> _assignments = new();

    public IReadOnlyDictionary<string, int> Assignments => _assignments;

    public override void EnterMethod_member_name(CSharpParser.Method_member_nameContext context)
    {
        // Error handling omitted for brevity.
        
        var identifier = context.GetText();
       
        
        _assignments.Add(identifier,4);
    }
}