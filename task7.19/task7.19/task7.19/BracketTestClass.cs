using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._19
{
    class Node
    {
        public int inf;
        public Node next;

        public Node(int inf, Node next)
        {
            this.inf = inf;
            this.next = next;
        }
    }
    class MyStack
    {
        Node head;
        public int count;
        public MyStack()
        {
            head = null;
            count = 0;
        }
        public bool StackIsEmpty()
        {
            return head == null;
        }
        public void AddElem(int inf)
        {
            Node p = new Node(inf, head);
            head = p;
            count++;
        }
        public int StackOut()
        {
            int k = head.inf;
            head = head.next;
            count--;
            return k;
        }

    }
}
