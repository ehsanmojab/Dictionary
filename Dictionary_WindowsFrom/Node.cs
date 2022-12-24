namespace Dictionary_WindowsFrom
{
    class Node
    {
        public string word;
        public string meaning;
        public Node lchild;
        public Node rchild;
        public int height;

        public Node()
        {
            word = null;
            meaning = null;
            rchild = null;
            lchild = null;
        }

        public Node(string word, string meaning)
        {
            this.word = word;
            this.meaning = meaning;
            lchild = null;
            rchild = null;
        }
        public Node(Node node)
        {
            word = node.word;
            meaning = node.meaning;
            rchild = node.rchild;
            lchild = node.lchild;
            height = node.height;
        }

        public static bool operator <(Node n1, Node n2)
        {
            string s1 = n1.word, s2 = n2.word;
            if (s1 == null && s2 == null)
                return false;
            else if (s1 == null && s2 != null)
                return true;
            else if (s2 == null)
                return false;
            for (int i = 0; ; i++)
            {
                if (i == s1.Length && i == s2.Length)
                    return false;
                else if (i == s1.Length && i != s2.Length)
                    return true;
                else if (i == s2.Length)
                    return false;
                else if (s1[i] == s2[i])
                    continue;
                else if (s1[i] < s2[i])
                    return true;
                else if (s1[i] > s2[i])
                    return false;
            }
        }
        public static bool operator >(Node n1, Node n2)
        {
            string s1 = n1.word, s2 = n2.word;
            if (s1 == null && s2 == null)
                return false;
            else if (s1 != null && s2 == null)
                return true;
            else if (s1 == null)
                return false;
            for (int i = 0; ; i++)
            {
                if (i == s1.Length && i == s2.Length)
                    return false;
                else if (i != s1.Length && i == s2.Length)
                    return true;
                else if (i == s1.Length)
                    return false;
                else if (s1[i] == s2[i])
                    continue;
                else if (s1[i] > s2[i])
                    return true;
                else if (s1[i] < s2[i])
                    return false;
            }
        }
    }
}
