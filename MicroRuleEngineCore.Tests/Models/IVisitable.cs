namespace MicroRuleEngineCore.Tests.Models
{
    public interface IVisitable<out T>
    {
        void Accept(IVisitor<T> visitor);
    }
}