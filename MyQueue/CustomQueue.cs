using System;
//using Users;

namespace MyQueue
{
    public class UsersQueue<T>
    {
        public WLLNode<T> Head { get; set; }

        public WLLNode<T> Tail { get; set; }

        public int Count { get; set; }


        public WLLNode<T> Enqueue(T value)
        {
            WLLNode<T> node = new WLLNode<T>(value);

            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count +=1;
                return node;
            }

        // This points the tail to the new node
            this.Tail.Next = node;

        // This sets the tail to the value of the new node
            this.Tail = node;

            return node;
        }

        public bool Dequeue(T value)
        {
            WLLNode<T> previous = null;
            WLLNode<T> temp = Head;
            while(temp != null)
            {
                if(temp.Value.Equals(value))
                {
                    // this keeps track of the previous node and sets it's pointer to the next next (3rd) node ignoring the node immediately after it.
                    previous.Next = temp.Next;

                    // this deletes the node (removing unnecessary space in the queue) and reduces the number of the values in the queue by 1.
                    temp.Next = null;
                    this.Count -=1;
                    return true;
                }
                previous = temp;
                temp = temp.Next;
            }
            return false;
        }

        public T Dequeue1()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("There are no users!");
            }
            T removedUser = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count -=1;
            return removedUser;
        }

        //This displays the data in the queue

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Value);
                //this changes temp to the new value
                temp = temp.Next;
            }
        }
    }
}

