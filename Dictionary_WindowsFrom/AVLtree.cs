using System;

namespace Dictionary_WindowsFrom
{
    class AVLtree
    {
        public Node root;

        public AVLtree()
        {
            root = new Node();
            root = null;
        }
        public AVLtree(string word, string meaning)
        {
            root = new Node(word, meaning);
            root.height = 1;
        }

        public bool Insert(Node xnode)
        {
            bool flag = false;
            InsertR(ref root, xnode, ref flag);
            if (flag)
                return false;
            else
            {
                return true;
            }

        }
        Node InsertR(ref Node root, Node xnode, ref bool flag)
        {
            if (root == null)
            {
                root = xnode;
                root.height = 1 + Max(root.lchild, root.rchild);
                return root;
            }

            if (root.word == xnode.word)
            {
                flag = true;
                root = xnode;
                root.height = 1 + Max(root.lchild, root.rchild);
                return root;
            }

            if (xnode < root)
            {
                root.lchild = InsertR(ref root.lchild, xnode, ref flag);
                root.height = 1 + Max(root.lchild, root.rchild);

                if (GetBF(root) > 1)
                {
                    Balance(ref root);
                }

            }
            else
            {
                root.rchild = InsertR(ref root.rchild, xnode, ref flag);
                root.height = 1 + Max(root.lchild, root.rchild);

                if (GetBF(root) > 1)
                {
                    Balance(ref root);
                }

            }

            return root;
        }
        public void Print_parent(Node parent, Node xnode)
        {
            if (parent == null)
            {
                Console.WriteLine("this Node is inserted in root!");
                return;
            }
            if (parent.rchild != null)
            {
                if (parent.rchild.word == xnode.word)
                {
                    Console.Write("parent is : ");
                    Print(parent);
                    Console.Write("inserted node is : ");
                    Print(parent.rchild);
                    Console.Write("right child is : ");
                    Print(parent.rchild.rchild);
                    Console.Write("left child is : ");
                    Print(parent.rchild.lchild);
                    Console.WriteLine();
                }
            }
            if (parent.lchild != null)
            {
                if (parent.lchild.word == xnode.word)
                {
                    Console.Write("parent is : ");
                    Print(parent);
                    Console.Write("inserted node is : ");
                    Print(parent.lchild);
                    Console.Write("right child is : ");
                    Print(parent.lchild.rchild);
                    Console.Write("left child is : ");
                    Print(parent.lchild.lchild);
                    Console.WriteLine();
                }
            }
        }

        int Max(Node xnode, Node ynode)//returns maximum height of 2 nodes
        {
            int x = GetHeight(xnode);
            int y = GetHeight(ynode);
            return (x > y) ? x : y;
        }
        int GetHeight(Node node)
        {
            if (node == null)
                return 0;
            return node.height;
        }

        int GetBF(Node node)
        {
            if (node == null)
                return 0;
            return Math.Abs(GetHeight(node.lchild) - GetHeight(node.rchild));
        }

        void Balance(ref Node root)
        {
            var x = new Node();
            var y = new Node();
            var z = new Node();

            x = root;

            if (GetHeight(x.lchild) > GetHeight(x.rchild))
            {
                y = x.lchild;

                if (GetHeight(y.lchild) > GetHeight(y.rchild))
                {
                    root = LL(ref x, ref y);

                }
                else
                {
                    z = y.rchild;
                    root = LR(ref x, ref y, ref z);

                }
            }
            else
            {
                y = x.rchild;

                if (GetHeight(y.lchild) > GetHeight(y.rchild))
                {
                    z = y.lchild;
                    root = RL(ref x, ref y, ref z);

                }
                else
                {
                    z = y.rchild;
                    root = RR(ref x, ref y);

                }
            }
        }

        Node LL(ref Node x, ref Node y)
        {
            x.lchild = y.rchild;
            y.rchild = x;


            y.height = UpdateHeight(y);
            if (y.lchild != null)
                y.lchild.height = UpdateHeight(y.lchild);
            if (y.rchild != null)
                y.rchild.height = UpdateHeight(y.rchild);

            return y;
        }
        Node RR(ref Node x, ref Node y)
        {
            x.rchild = y.lchild;
            y.lchild = x;

            y.height = UpdateHeight(y);
            if (y.rchild != null)
                y.rchild.height = UpdateHeight(y.rchild);
            if (y.lchild != null)
                y.lchild.height = UpdateHeight(y.lchild);

            return y;
        }
        Node LR(ref Node x, ref Node y, ref Node z)
        {
            x.lchild = z.rchild;
            y.rchild = z.lchild;
            z.lchild = y;
            z.rchild = x;

            if (z.rchild != null)
                z.rchild.height = UpdateHeight(z.rchild);
            if (z.lchild != null)
                z.lchild.height = UpdateHeight(z.lchild);
            z.height = UpdateHeight(z);

            return z;
        }
        Node RL(ref Node x, ref Node y, ref Node z)
        {
            x.rchild = z.lchild;
            y.lchild = z.rchild;
            z.lchild = x;
            z.rchild = y;

            if (z.rchild != null)
                z.rchild.height = UpdateHeight(z.rchild);
            if (z.lchild != null)
                z.lchild.height = UpdateHeight(z.lchild);
            z.height = UpdateHeight(z);

            return z;
        }

        public void Inorder()
        {
            Inorder_rec(root);
        }

        void Inorder_rec(Node node)
        {
            if (node != null)
            {
                Inorder_rec(node.lchild);
                Print(node);
                Inorder_rec(node.rchild);
            }
        }
        public void Print(Node root)
        {
            if (root == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(root.word + ' ' + root.meaning);
        }

        int UpdateHeight(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                node.height = 1 + Math.Max(UpdateHeight(node.rchild), UpdateHeight(node.rchild));
            }
            return node.height;
        }

        public void Search(string word)
        {
            int counter = 0;
            var xnode = new Node(word, "");
            bool flag = false;
            Console.WriteLine("Searching for {0}", word);
            if (!SearchR(ref root, xnode, ref flag, ref counter))
                Console.WriteLine("the word is not in dictionary");
            Console.WriteLine("number of searches : {0}", counter);
        }
        bool SearchR(ref Node root, Node xnode, ref bool flag, ref int counter)
        {
            if (root != null)
            {
                if (root.word == xnode.word)
                {
                    Console.WriteLine("this word found in root!");
                    Console.Write("right child : ");
                    Print(root.rchild);
                    Console.Write("left child : ");
                    Print(root.lchild);
                    flag = true;
                    counter++;
                    return flag;
                }
                else
                    counter++;
            }
            else
                return false;//added this else

            if (root.lchild != null)
            {
                if (root.lchild.word == xnode.word)
                {
                    Console.Write("parent of {0} is : ", xnode.word);
                    Print(parent_of(ref root, xnode));
                    Console.Write("left child of {0} is : ", xnode.word);
                    Print(root.lchild.lchild);
                    Console.Write("right child of {0} is : ", xnode.word);
                    Print(root.lchild.rchild);
                    flag = true;
                    counter++;
                    return flag;
                }
                else
                    counter++;
            }

            if (root.rchild != null)
            {
                if (root.rchild.word == xnode.word)
                {
                    Console.Write("parent of {0} is : ", xnode.word);
                    Print(parent_of(ref root, xnode));

                    Console.Write("left child of {0} is : ", xnode.word);
                    Print(root.rchild.lchild);
                    Console.Write("right child of {0} is : ", xnode.word);
                    Print(root.rchild.rchild);
                    flag = true;
                    counter++;
                    return flag;
                }
                else
                    counter++;
            }

            if (xnode < root)
            {
                counter++;
                SearchR(ref root.lchild, xnode, ref flag, ref counter);
            }
            else
            {
                counter++;
                SearchR(ref root.rchild, xnode, ref flag, ref counter);
            }

            return flag;
        }
        public Node parent_of(ref Node root, Node xnode) // returns parent of the node we are searching for
        {
            if (root == null)
                return null;

            if (root.word == xnode.word)
                return null;
            else if (root != null)
            {
                if (root.lchild != null)
                {
                    if (root.lchild.word == xnode.word)
                        return root;
                }
                if (root.rchild != null)
                {
                    if (root.rchild.word == xnode.word)
                        return root;
                }
            }

            if (xnode < root)
                return parent_of(ref root.lchild, xnode);
            else if (xnode > root)
                return parent_of(ref root.rchild, xnode);
            else
                return null;
        }
        public Node SearchRD(ref Node root, Node xnode)// searchs for the node and returns it
        {
            if (root != null)
            {
                if (root.word == xnode.word)
                {
                    return root;
                }
            }

            if (xnode < root)
                return SearchRD(ref root.lchild, xnode);
            else if (xnode > root)
                return SearchRD(ref root.rchild, xnode);
            else
                return null;
        }

        public Node parent_of(ref Node root, Node xnode, ref int counter) // returns parent of the node we are searching for
        {
            if (root == null)
                return null;
            if (root.word == xnode.word)
                return null;
            else if (root != null)
            {
                if (root.lchild != null)
                {
                    if (root.lchild.word == xnode.word)
                    {
                        counter++;
                        return root;
                    }
                }
                if (root.rchild != null)
                {
                    if (root.rchild.word == xnode.word)
                    {
                        counter++;
                        return root;
                    }
                }
            }

            if (xnode < root)
            {
                counter++;
                return parent_of(ref root.lchild, xnode);
            }
            else if (xnode > root)
            {
                counter++;
                return parent_of(ref root.rchild, xnode);
            }
            else
            {
                counter++;
                return null;
            }
        }
        public Node Delete(ref Node root, Node xnode, ref bool flag)
        {
            if (root == null)
                return null;
            if (xnode < root)
            {
                if (root.lchild != null)
                {
                    root.lchild = Delete(ref root.lchild, xnode, ref flag);
                    if (root.lchild != null)
                        root.lchild.height = UpdateHeight(root.lchild);
                    root.height = UpdateHeight(root);
                }
            }
            else if (xnode > root)
            {
                if (root.rchild != null)
                {
                    root.rchild = Delete(ref root.rchild, xnode, ref flag);
                    if (root.rchild != null)
                        root.rchild.height = UpdateHeight(root.rchild);
                    root.height = UpdateHeight(root);
                }
            }
            else
            {
                Node temp = new Node();
                if (root.lchild == null)
                {
                    temp = root.rchild;
                    flag = true;
                    return temp;
                }
                else if (root.rchild == null)
                {
                    temp = root.lchild;
                    flag = true;
                    return temp;
                }

                var candidate = Candidate(ref root);

                root.word = candidate.word;
                root.meaning = candidate.meaning;

                root.height = UpdateHeight(root);

                if (GetBF(root) > 1)
                    Balance(ref root);

                flag = true;
            }

            root.height = UpdateHeight(root);
            if (GetBF(root) > 1)
                Balance(ref root);
            return root;
        }

        public Node Candidate(ref Node root) // changes root to candidate node and balance from candidate to root
        {
            if (root == null)
                return root;
            Node node = root;
            if (node.lchild != null)
            {
                node = node.lchild;
                Node parent = node;
                while (node.rchild != null)
                {
                    node = node.rchild;
                    if (node.rchild != null)
                        parent = node;
                }
                Node candid = node;
                if (node.lchild != null)
                    parent.rchild = node.lchild;
                else
                {
                    parent.rchild = null;
                }
                if (GetBF(parent) > 1)
                    Balance(ref parent);
                return candid;
            }
            else
            {
                node = root.rchild;
                Node parent = node;
                while (node.lchild != null)
                {
                    node = node.lchild;
                    if (node.lchild != null)
                        parent = node;
                }
                Node candid = node;
                if (node.rchild != null)
                    parent.lchild = node.rchild;
                else
                {
                    parent.lchild = null;
                }
                if (GetBF(node.lchild) > 1)
                    Balance(ref node.lchild);
                return candid;
            }
        }
    }
}