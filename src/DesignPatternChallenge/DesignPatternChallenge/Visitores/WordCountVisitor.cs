using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Visitores;

public class WordCountVisitor : IDocumentVisitor
{
    public int TotalWords { get; private set; } = 0;

    public void Visit(Paragraph paragraph)
    {
        TotalWords += paragraph.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public void Visit(Image image) { /* não conta palavras */ }

    public void Visit(Table table)
    {
        foreach (var row in table.Cells)
            foreach (var cell in row)
                TotalWords += cell.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
