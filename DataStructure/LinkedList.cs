
namespace DataStructure
{
    public class LinkedList
    {
        private class Node
        {
            internal int Value;
            internal Node? Next { get; set; }

            public Node(int value)
            {
                Value = value;
            }

            public void SetNext(Node node)
            {
                Next = node;
            }
        }
        private Node First { get; set; }
        private Node Last { get; set; }

        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (First == null)
                First = Last = node;

            else
            {
                node.SetNext(First);
                First = node;
            }
        }

        public void AddLast(int item)
        {
            var node = new Node(item);
            if (First == null)
                First = Last = node;
            else
            {
                Last.Next = node;
                Last = node;
            }
        }

        public void DeleteFirst()
        {
            if (First != null)
            {
                if (First == Last)
                    First = Last = null;

                else
                {
                    var second  = First.Next;
                    First.Next = null;
                    First = second;
                }
            }
        }

        public void DeleteLast()
        {
            if (First != null)
            {
                var array = new List<Node>();
                var node = First;
                array.Add(First);
                while (node.Next != null)
                {
                    array.Add(node.Next);
                    node = node.Next;
                }

                if (array.Count == 1)
                {
                    Last = First = null;
                }
                else
                {
                    Last = array[array.Count - 2];
                    Last.Next = null;
                }
            }
        }

        public void Contains(int item)
        {

        }
    }





}
