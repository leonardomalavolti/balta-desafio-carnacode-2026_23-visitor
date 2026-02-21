using DesignPatternChallenge.Models;
using DesignPatternChallenge.Visitores;

var doc = new Document("Relatório Anual");
doc.AddElement(new Paragraph("Este é o relatório anual da empresa."));
doc.AddElement(new Image("grafico.png", 800, 600));
doc.AddElement(new Paragraph("Resultados financeiros:"));
doc.AddElement(new Table(3, 4));
doc.AddElement(new Paragraph("Conclusão com recomendações."));

Console.WriteLine("=== Render do Documento ===");
foreach (var el in doc.Elements) el.Render();

// Export HTML
var htmlVisitor = new HtmlExportVisitor();
doc.Accept(htmlVisitor);
Console.WriteLine("\n=== HTML Export (amostra) ===");
Console.WriteLine(htmlVisitor.Html.Substring(0, Math.Min(200, htmlVisitor.Html.Length)) + "...");

// Export PDF
var pdfVisitor = new PdfExportVisitor();
doc.Accept(pdfVisitor);
Console.WriteLine("\n=== PDF Export (amostra) ===");
Console.WriteLine(pdfVisitor.Pdf.Substring(0, Math.Min(150, pdfVisitor.Pdf.Length)) + "...");

// Word count
var wordCounter = new WordCountVisitor();
doc.Accept(wordCounter);
Console.WriteLine($"\nTotal de palavras: {wordCounter.TotalWords}");

// Validation
var validator = new ValidationVisitor();
doc.Accept(validator);
Console.WriteLine($"Documento válido: {validator.IsValid}");