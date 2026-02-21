using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Models;

public class Document
{
    public string Title { get; set; }
    public List<DocumentElement> Elements { get; set; } = new();

    public Document(string title)
    {
        Title = title;
    }

    public void AddElement(DocumentElement element)
    {
        Elements.Add(element);
    }

    public void Accept(IDocumentVisitor visitor)
    {
        foreach (var element in Elements)
            element.Accept(visitor);
    }
}