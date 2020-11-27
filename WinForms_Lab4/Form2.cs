using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_lab4;

namespace WinForms_Lab4
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] langs = textBox2.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
           
            if(langs.Length > 1 && !string.IsNullOrEmpty(textBox1.Text))
            {
                WordList list = new WordList(name: textBox1.Text, languages: langs);
                list.Save();
                Close();
            }
            else
            {
                MessageBox.Show("List needs a valid name and two or more languages", "List error" , MessageBoxButtons.OK);
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
