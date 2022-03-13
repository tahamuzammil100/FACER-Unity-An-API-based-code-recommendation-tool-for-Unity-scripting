using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using AntlrExample;


var text = File.ReadAllText("C:/Users/aenah/RiderProjects/antlr-example/csharp_test.txt");
var stream = CharStreams.fromString(text);
var lexer = new CSharpLexer(stream);

var tokens = new CommonTokenStream(lexer);
var parser = new CSharpParser(tokens) { BuildParseTree = true };

var parseTree = parser.compilation_unit();


var listener = new TestListener();
ParseTreeWalker.Default.Walk(listener, parseTree);

foreach (var (identifier, value) in listener.Assignments)
{
    Console.WriteLine($"Assigned {identifier} to {identifier}.");
}
