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
            string word = txtword.Text;
            string meaning = txtmeaning.Text;

            if (word.Length < 1)
                return;

            if (D.Insert(word, meaning))
            {
                int index = word.ToLower()[0] - 97;
                var parent = D.HashTable[index].parent_of(ref D.HashTable[index].root, new Node(word, meaning));
                
                listBox1.Items.Add("\"" + word + " : " + meaning + "\"" + "added to Dictionary!");

                Print_parent(parent, new Node(word, meaning));
                
            }
            else
            {
                listBox1.Items.Add("this word already exists in Dictionary!");
            }
        }
        string Print(Node root)
        {
            if (root == null)
                return "null";
            else
                return root.word;
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
            if(e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(txtword, true, false, false, false);
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
            if(txtword.Text.Length > 1)
            {
                if (D.Delete(txtword.Text))
                    listBox1.Items.Add("\"" + txtword.Text + "\"" + " has been Deleted from Dictionary");
                else
                    listBox1.Items.Add("the word dosen't exist in Dictionary!");
            }
        }
    }
}
