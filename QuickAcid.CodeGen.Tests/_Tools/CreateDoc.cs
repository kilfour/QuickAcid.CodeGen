using QuickExplainIt;

namespace QuickAcid.TestsDeposition._Tools;

public class CreateDoc
{
    [Fact(Skip = "Needs QuickExplainIt 0.1.1")]
    public void Go()
    {
        new Document().ToFile("reference.md", typeof(CreateDoc).Assembly);
    }
}