using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bt = new BinarySearchTree();
            bt.AddElement(101);
            bt.AddElement(64);
            bt.AddElement(105);
            bt.AddElement(14);
            bt.AddElement(79);

            bt.Search(14);
            Console.ReadLine();


        }
    }
}
