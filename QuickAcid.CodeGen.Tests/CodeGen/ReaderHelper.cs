using QuickExplainIt.Text;

namespace QuickAcid.TestsDeposition.Linqy.CodeGen;

public static class Reader
{
    public static LinesReader FromRun(QAcidScript<Acid> script)
    {
        var code = new QCodeState(script).GenerateCode();
        var reader = LinesReader.FromStringList([.. code.Split(Environment.NewLine).Select(a => a.Trim())]);
        reader.Skip(7);
        return reader;
    }
}