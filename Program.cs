namespace HashTable_and_BST_Problems
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            // hash table 

            // Use Case 1
            string sentence1 = "To be or not to be";
            string[] words1 = sentence1.Split(' ');
            HashTable hashTable1 = new HashTable(words1.Length);
            foreach (string word in words1)
            {
                hashTable1.Insert(word);
            }
            Console.WriteLine("Frequency of 'be': " + hashTable1.GetFrequency("be"));

            // Use Case 2
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words2 = paragraph.Split(' ');
            HashTable hashTable2 = new HashTable(words2.Length);
            foreach (string word in words2)
            {
                hashTable2.Insert(word);
            }
            Console.WriteLine("Frequency of 'paranoid': " + hashTable2.GetFrequency("paranoid"));

            // Use Case 3
            hashTable2.Remove("avoidable");
            Console.WriteLine("Frequency of 'avoidable' after removal: " + hashTable2.GetFrequency("avoidable"));



            //   #  BinarySearchTree 


            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            // UC 1: Creating a BST with 56, 30, and 70
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);

            // UC 2: Checking if all nodes are added
            int size = tree.Size();
            Console.WriteLine("Size of the tree: " + size);

            // UC 3: Searching for 63
            int searchKey = 63;
            bool found = tree.Search(searchKey);
            if (found)
                Console.WriteLine(searchKey + " found in the tree.");
            else
                Console.WriteLine(searchKey + " not found in the tree.");
    
            }
        }
    }
   
