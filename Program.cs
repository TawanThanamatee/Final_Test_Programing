using System;

namespace Final_test_programming._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input skill name : ");
            string name = Console.ReadLine();
            while (name != "?")
            {
                Node node = new Node(name);
                Console.Write("Add dependency for {0} ? (Y/N) : ", name);
                char Yes_No = char.Parse(Console.ReadLine());
                if (Yes_No == 'Y' || Yes_No == 'y')
                {
                    Console.Write("Input skill name : ");
                    name = Console.ReadLine();
                    node.nextNode = node;
                }
                else if (Yes_No == 'N' || Yes_No == 'n')
                {
                    Console.WriteLine(node.name);
                }
                else 
                    Console.WriteLine("Plese input Y/N.");          
            }
        }
    }
    class Node
    {
        public string name;
        public Node nextNode;

        public Node(string nameValue)
        {    
                name = nameValue;
                nextNode = null;   
        }
    }
}
