using ClassLibrary_lab4;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinForms_Lab4
{
    public partial class Form4 : Form
    {
        private int tries;
        private int rightAnswers;
        private WordList practice = null;
        private Word word = null;



        public Form4()
        {
            InitializeComponent();

            
            foreach (string str in WordList.GetLists())
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(str));
                
            }
            label1.Font = new System.Drawing.Font("Calibri", 11);
                        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            practice = WordList.LoadList(listBox1.SelectedItem.ToString());
            if (listBox1.SelectedItem != null)
            {
                loadButton.Enabled = true;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = false;

            word = practice.GetWordToPractice();

            textBox1.Enabled = true;            
            answerButton.Enabled = true;
            stopButton.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;


            label2.Font = new System.Drawing.Font("Calibri", 20);

            label3.Text = " From: " + practice.Languages[word.FromLanguage];
            label2.Text = word.Translations[word.FromLanguage];
            label4.Text = "To: " +practice.Languages[word.ToLanguage];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            tries++;
            label5.Visible = true;
            label5.Font = new System.Drawing.Font("Calibri", 20);

            if (textBox1.Text == word.Translations[word.ToLanguage].ToLower())
            {
                rightAnswers++;
                label5.ForeColor = System.Drawing.Color.Green;
                label5.Text = "Correct";
            }
            else
            {                
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "Wrong";
            }
            textBox1.Clear();
            word = practice.GetWordToPractice();
            label2.Text = word.Translations[word.FromLanguage];
            label3.Text = " From: " + practice.Languages[word.FromLanguage];
            label4.Text = "To: " + practice.Languages[word.ToLanguage];

        }
        

        private void stopButton_Click(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Text = rightAnswers.ToString() + " correct out of " + tries;            
        }
    }
}
