using System;

namespace CommonProgram
{
    class CustomLinkedList
    {
        public class Node
        {
            public int value;
            public Node next;
        }

        Node first;
        Node last;

        public void AddLast(int item)
        {
            var node = new Node();
            node.value = item;

            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }

        public void AddFirst(int item)
        {
            var node = new Node();
            node.value = item;
            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
        }

        public int IndexOf(int item)
        {
            var current = first;
            int index = 0;
            while(current != null)
            {
                if(current.value == item)
                {
                    return index;
                }
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            if (IndexOf(item) != -1)
                return true;

            return false;
        }

        public void RemoveFirst()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            if (first == last)
            {
                first = last = null;
                return;
            }
                
            var second = first.next;
            first.next = null;
            first = second;
        }

        public void RemoveLast()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            if (first == last)
            {
                first = last = null;
                return;
            }
                
            var current = first;
            while(current != null)
            {
                if (current.next == last)
                    break;

                current = current.next;

            }

            current.next = null;
            last = current;
        }

        public void Remove(int item)
        {

        }
             

        private bool isEmpty()
        {
            return first == null;
        }
    }
}
