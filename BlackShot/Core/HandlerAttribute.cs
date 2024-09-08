namespace Core
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HandlerAttribute(int id) : Attribute
    {
        public int Id { get; } = id;
    }
}
