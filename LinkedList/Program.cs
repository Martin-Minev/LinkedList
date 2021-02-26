using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);

            SoftUniLinkedList linkedList = new SoftUniLinkedList();

            Console.WriteLine("Remove empty head: " + linkedList.RemoveHead());

            for (int i = 0; i < 3; i++)
            {
                linkedList.AddHead(new Node(i));
            }

            for (int i = 0; i < 3; i++)
            {
                linkedList.AddTail(new Node(i));
            }

            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);

            Console.WriteLine("Remove tail: " + linkedList.RemoveTail().Value);

            Node currentNode = linkedList.Tail;

            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}
            Console.WriteLine("Foreach from head:");
            linkedList.ForeachFromHead((node) => { Console.WriteLine($"From action: {node.Value}");});

            int[] linkedListAsArray = linkedList.ToArray();
        }
    }
}
