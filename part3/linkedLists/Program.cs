using linkedLists;

namespace linkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(3);
            LinkedList linkedList = new LinkedList(head);


            linkedList.Append(4);
            linkedList.Append(2);
            linkedList.Prepend(1);
            linkedList.Print();
            linkedList.Sort();
            linkedList.Print();
            Console.WriteLine(linkedList.IsCircular());
        }
    }
}

