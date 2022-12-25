using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_WindowsFrom
{
    public partial class Dictionary_Form : Form
    {
        Dictionary D;
        public Dictionary_Form()
        {
            InitializeComponent();

            D = new Dictionary();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //txtword.Focus();
            txtmeaning.Visible = true;
            lblmeaning.Visible = true;
            lblword.Text = "Enter Word : ";

            string word = txtword.Text.ToLower();
            string meaning = txtmeaning.Text.ToLower();

            if (word.Length < 1)
                return;

            if (D.Insert(word, meaning))
            {
                int index = word.ToLower()[0] - 97;
                var parent = D.HashTable[index].parent_of(ref D.HashTable[index].root, new Node(word, meaning));

                listBox1.Items.Add("\"" + word + " : " + meaning + "\"" + "added to Dictionary!");

                Print_parent(parent, new Node(word, meaning));

                txtword.Focus();
            }
            else
            {
                listBox1.Items.Add("this word already exists in Dictionary!");
                txtword.Focus();
            }
        }
        string Print(Node root)
        {
            if (root == null)
                return "null";
            else
                return root.word + " : " + root.meaning;
        }
        void Print_parent(Node parent, Node xnode)
        {
            if (parent == null)
            {
                listBox2.Items.Add("word inserted in root!");
                listBox2.Items.Add("\n");
                return;
            }
            if (parent.rchild != null)
            {
                if (parent.rchild.word == xnode.word)
                {
                    listBox2.Items.Add("parent is : " + Print(parent));
                    listBox2.Items.Add("inserted node is : " + Print(parent.rchild));
                    listBox2.Items.Add("right child is : " + Print(parent.rchild.rchild));
                    listBox2.Items.Add("left child is : " + Print(parent.rchild.lchild));
                    listBox2.Items.Add("\n");
                }
            }
            if (parent.lchild != null)
            {
                if (parent.lchild.word == xnode.word)
                {
                    listBox2.Items.Add("parent is : " + Print(parent));
                    listBox2.Items.Add("inserted node is : " + Print(parent.lchild));
                    listBox2.Items.Add("right child is : " + Print(parent.lchild.rchild));
                    listBox2.Items.Add("left child is : " + Print(parent.lchild.lchild));
                    listBox2.Items.Add("\n");
                }
            }
        }

        private void txtword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(txtword, true, false, false, false);
                if (!txtmeaning.Visible)
                {
                    btnInsert_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
                SelectNextControl(txtword, false, false, false, false);

            }
        }

        private void txtmeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(txtword, false, false, false, false);
                btnInsert_Click(sender, e);
                txtword.Focus();
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
                SelectNextControl(txtmeaning, false, false, false, false);
            }
        }

        private void txtword_Enter(object sender, EventArgs e)
        {
            txtword.Clear();
            txtmeaning.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //txtword.Focus();
            txtmeaning.Visible = false;
            lblmeaning.Visible = false;
            lblword.Text = "Enter Word : ";

            if (txtword.Text.Length >= 1)
            {
                if (D.Delete(txtword.Text))
                    listBox1.Items.Add("\"" + txtword.Text + "\"" + " Deleted from Dictionary");
                else
                    listBox1.Items.Add("the word dosen't exist in Dictionary!");

                txtword.Focus();
            }
        }

        private void Dictionary_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnInorder_Click(object sender, EventArgs e)
        {
            if (txtword.Text.Length < 1)
            {
                txtword.Focus();
                txtmeaning.Visible = false;
                lblmeaning.Visible = false;
                lblword.Text = "Enter a character : ";
            }
            else
            {
                listBox2.Items.Clear();

                Inorder(txtword.Text[0]);

                txtword.Focus();
                txtmeaning.Visible = true;
                lblmeaning.Visible = true;
                lblword.Text = "Enter Word : ";
            }
        }
        public void Inorder(char ch)
        {
            Inorder_rec(D.HashTable[ch - 97].root);
        }

        void Inorder_rec(Node node)
        {
            if (node != null)
            {
                Inorder_rec(node.lchild);
                listBox2.Items.Add(Print(node));
                Inorder_rec(node.rchild);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblword.Text = "Enter Word :";

            string word = txtword.Text.ToLower();
            string meaning = txtmeaning.Text.ToLower();

            if (word.Length < 1)
                return;

            var xnode = new Node(word, meaning);
            int counter = 0;
            Node parent = D.HashTable[word[0] - 97].parent_of(ref D.HashTable[word[0] - 97].root, xnode, ref counter);

            if (D.HashTable[word[0] - 97].root == null)
            {
                listBox2.Items.Add("this word dosen't exist in dictionary!");
                return;
            }


            if (parent == null)
            {
                listBox2.Items.Add("Node found in root!");

                var node = D.HashTable[word[0] - 97].SearchRD(ref D.HashTable[word[0] - 97].root, xnode);
                listBox2.Items.Add("meaning : " + node.meaning);
                listBox2.Items.Add("Left Child : " + Print(node.lchild));
                listBox2.Items.Add("Right Child : " + Print(node.rchild));
                listBox2.Items.Add("height : " + (node.height - 1).ToString() + '\n');
            }

            else if (parent != null)
            {
                if (parent.lchild != null)
                {
                    listBox2.Items.Add("parent of " + word + " : " + parent.word);
                    if (parent.lchild.word == xnode.word)
                    {
                        listBox2.Items.Add("meaning : " + parent.lchild.meaning);
                        listBox2.Items.Add("Left Child : " + Print(parent.lchild.lchild));
                        listBox2.Items.Add("Right Child : " + Print(parent.lchild.rchild));
                        listBox2.Items.Add("Number of Search : " + counter.ToString());
                        listBox2.Items.Add("height : " + (parent.lchild.height - 1).ToString() + '\n');
                    }
                }
                if (parent.rchild != null)
                {
                    listBox2.Items.Add("parent of " + word + " : " + parent.word);
                    if (parent.rchild.word == xnode.word)
                    {
                        listBox2.Items.Add("meaning : " + parent.rchild.meaning);
                        listBox2.Items.Add("Left Child : " + Print(parent.rchild.lchild));
                        listBox2.Items.Add("Right Child : " + Print(parent.rchild.rchild));
                        listBox2.Items.Add("Number of Search : " + counter.ToString());
                        listBox2.Items.Add("height : " + (parent.rchild.height - 1).ToString() + '\n');
                    }
                }
            }
            else
            {
                listBox2.Items.Add("this word dosen't exist in dictionary!");
            }
        }

        private void btnPrintDictionary_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); 
            for (int i = 0; i < 26; i++)
            {
                Inorder((char)(i + 97));
            }
        }

        private void btnInorder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnInorder_Click(sender, e);
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            string word = txtword.Text;
            if (word.Length < 1)
                return;

            if (D.HashTable[word.ToLower()[0] - 97].root == null)
                return;

            var ans = D.HashTable[word[0] - 97].SearchRD(ref D.HashTable[word.ToLower()[0] - 97].root, new Node(word, ""));

            if (ans == null)
                return;

            if (ans != null)
            {

                string meaning = txtmeaning.Text.ToLower();

                if (meaning == ans.meaning)
                {
                    listBox1.Items.Add("correct!\n");
                }
                else
                {
                    listBox1.Items.Add("not correct! Try again!");
                }

            }
        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

        }

        private void lblclearlist_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
