using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_and_BST_Problems
{
        class MyMapNode
        {
            public string Key { get; set; }
            public int Value { get; set; }
        }

        // Define the HashTable class
        class HashTable
        {
            private LinkedList<MyMapNode>[] table;

            public HashTable(int size)
            {
                table = new LinkedList<MyMapNode>[size];
            }

            // Hash function to calculate the index
            private int GetIndex(string key)
            {
                int hash = key.GetHashCode();
                return Math.Abs(hash % table.Length);
            }

            // Insert a key-value pair into the hash table
            public void Insert(string key)
            {
                int index = GetIndex(key);

                if (table[index] == null)
                {
                    table[index] = new LinkedList<MyMapNode>();
                }

                // Check if the word already exists in the linked list
                foreach (MyMapNode node in table[index])
                {
                    if (node.Key == key)
                    {
                        node.Value++;
                        return;
                    }
                }

                // If the word is not found, add it to the linked list
                table[index].AddLast(new MyMapNode { Key = key, Value = 1 });
            }

            // Find the frequency of a word in the hash table
            public int GetFrequency(string key)
            {
                int index = GetIndex(key);

                if (table[index] != null)
                {
                    foreach (MyMapNode node in table[index])
                    {
                        if (node.Key == key)
                        {
                            return node.Value;
                        }
                    }
                }

                 return 0;
            }

            // Remove a specific word from the hash table
            public void Remove(string key)
            {
                int index = GetIndex(key);

                if (table[index] != null)
                {
                    LinkedListNode<MyMapNode> currentNode = table[index].First;

                    while (currentNode != null)
                    {
                        if (currentNode.Value.Key == key)
                        {
                            table[index].Remove(currentNode);
                            return;
                        }
                        currentNode = currentNode.Next;
                    }
                }
            }
        }
    }

