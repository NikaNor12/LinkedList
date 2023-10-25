namespace G19_20231021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> list = new MyLinkedList<string>();

            list.AddFirst("Nika");
            list.AddFirst("Nina");
            list.AddFirst("Nino");
            list.AddFirst("Gio");
            list.AddFirst("Toko");
            list.AddLast("Nuca");
            list.AddLast("Mariam");


            PrintNodes(list._first);
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("With Enumerator ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintNodes(MyLinkedListNode<string>? node)
        {
            while (node != null)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}