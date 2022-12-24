using System;

namespace Dictionary_WindowsFrom
{
    class Dictionary
    {
        public AVLtree[] HashTable;

        public Dictionary()
        {
            HashTable = new AVLtree[26];
            for (int i = 0; i < 26; i++)
                HashTable[i] = new AVLtree();
        }

        public bool Insert(string word, string meaning)
        {
            int index = word.ToLower()[0] - 97;
            var xnode = new Node(word, meaning);
            var parent = new Node();
            if (HashTable[index].Insert(xnode))
            {
                parent = HashTable[index].parent_of(ref HashTable[index].root, xnode);
                HashTable[index].Print_parent(parent, xnode);
                return true;
            }
            return false;
        }

        public void Search(string word)
        {
            int index = word.ToLower()[0] - 97;
            HashTable[index].Search(word);
        }

        public bool Delete(string word)
        {
            bool flag = false;
            int index = word.ToLower()[0] - 97;
            Node xnode = new Node(word, "");
            HashTable[index].root = HashTable[index].Delete(ref HashTable[index].root, xnode, ref flag);
            if (flag)
                return true;
            else
                return false;
        }

        public void Inorder(char ch)
        {
            HashTable[ch - 97].Inorder();
        }

        public void Print_all()
        {
            for (int i = 0; i < 26; i++)
                HashTable[i].Inorder();
        }
    }
}
