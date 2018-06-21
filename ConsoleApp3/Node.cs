using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Node
    {
        private int data;
        private Node left;
        private Node right;

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public Node Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public Node Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
