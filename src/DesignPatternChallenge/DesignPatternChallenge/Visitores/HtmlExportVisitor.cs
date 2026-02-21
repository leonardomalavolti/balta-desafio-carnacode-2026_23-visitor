using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Visitores;

public class HtmlExportVisitor : IDocumentVisitor
{
    public string Html { get; private set; } = "";

    public void Visit(Paragraph paragraph)
    {
        Html += $"<p style='font-family:{paragraph.FontFamily};font-size:{paragraph.FontSize}px'>{paragraph.Text}</p>";
    }

    public void Visit(Image image)
    {
        Html += $"<img src='{image.Url}' width='{image.Width}' height='{image.Height}' alt='{image.Alt}' />";
    }

    public void Visit(Table table)
    {
        Html += "<table>";
        foreach (var row in table.Cells)
        {
            Html += "<tr>";
            foreach (var cell in row)
                Html += $"<td>{cell}</td>";
            Html += "</tr>";
        }
        Html += "</table>";
    }
}

