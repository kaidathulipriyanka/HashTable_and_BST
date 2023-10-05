using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_and_BST_Problems
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public class Node
        {
            public T Key;
            public Node Left, Right;

            public Node(T item)
            {
                Key = item;
                Left = Right = null;
            }
        }

        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(T key)
        {
            root = InsertRec(root, key);
        }

        private Node InsertRec(Node root, T key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key.CompareTo(root.Key) < 0)
                root.Left = InsertRec(root.Left, key);
            else if (key.CompareTo(root.Key) > 0)
                root.Right = InsertRec(root.Right, key);

            return root;
        }

        public int Size()
        {
            return Size(root);
        }

        private int Size(Node node)
        {
            if (node == null)
                return 0;

            return 1 + Size(node.Left) + Size(node.Right);
        }

        public bool Search(T key)
        {
            return SearchRec(root, key);
        }

        private bool SearchRec(Node root, T key)
        {
            if (root == null)
                return false;

            if (key.CompareTo(root.Key) == 0)
                return true;

            if (key.CompareTo(root.Key) < 0)
                return SearchRec(root.Left, key);

            return SearchRec(root.Right, key);
        }
    }
}
