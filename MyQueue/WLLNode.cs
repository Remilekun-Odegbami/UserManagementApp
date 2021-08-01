
namespace MyQueue
{
    public class WLLNode<T>
    {
        public WLLNode(T value)
        {
            // this sets the value of the WLLNode property to the value the user passes in
            this.Value = value;
        }
        // WLLNode constructors
        public T Value { get; set; }
        public WLLNode<T> Next { get; set; } // this enables each node find the pointer to the node after it.
    }
} 