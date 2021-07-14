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

        public int RemoveAtIndex(int index)
        {
            if (isEmpty())
                throw new InvalidOperationException();

            if(first == last)
            {
                first = last = null;
                return 1;
            }

            if(index == 0)
            {
                RemoveFirst();
                return 1;
            }

            int count = 0;
            var current = first;
            while(current != null)
            {
                if(count == index-1)
                {
                    break;
                }
                count++;
                current = current.next;                
            }

            if(current == last)
            {
                RemoveLast();
                return 1;
            }

            if(current.next == last)
            {
                current.next = null;
                last = current;
                return 1;
            }
            else
            {
                var current1 = current.next.next;
                current.next = null;
                current.next = current1;
                return 1;
            }
        }
             

        private bool isEmpty()
        {
            return first == null;
        }
    }
}
