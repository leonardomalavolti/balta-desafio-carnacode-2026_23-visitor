using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Visitores;

public class PdfExportVisitor : IDocumentVisitor
{
    public string Pdf { get; private set; } = "";

    public void Visit(Paragraph paragraph)
    {
        Pdf += $"PDF_TEXT({paragraph.Text}, {paragraph.FontFamily}, {paragraph.FontSize}) ";
    }

    public void Visit(Image image)
    {
        Pdf += $"PDF_IMAGE({image.Url}, {image.Width}, {image.Height}) ";
    }

    public void Visit(Table table)
    {
        Pdf += $"PDF_TABLE({table.Rows}, {table.Columns}) ";
    }
}
