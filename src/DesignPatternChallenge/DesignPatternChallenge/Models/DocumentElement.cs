using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Models;

public abstract class DocumentElement
{
    public abstract void Accept(IDocumentVisitor visitor);
    public abstract void Render();
}
