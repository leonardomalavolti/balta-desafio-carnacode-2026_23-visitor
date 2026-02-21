using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Interfaces;

public interface IDocumentVisitor
{
    void Visit(Paragraph paragraph);
    void Visit(Image image);
    void Visit(Table table);
}
