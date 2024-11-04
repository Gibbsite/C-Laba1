namespace StackLibrary
{
    public interface IStack
    {
        StackItem top { get; set; }
        bool isEmpty();
        void Push(string value);
        string Read();
        string Pop();
        bool isEqual(IStack other);
    }
}
