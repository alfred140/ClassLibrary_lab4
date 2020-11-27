using ClassLibrary_lab4;
using System;
using System.Windows.Forms;

namespace WinForms_Lab4
{
    public partial class WordForm : Form
    {
        public WordForm()
        {
            InitializeComponent();
            button4.Enabled = false;
            label1.Font = new System.Drawing.Font("calibri" , 10);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string listName = Text;

            WordList w = WordList.LoadList(listName);

            dataGridView1.ColumnCount = w.Languages.Length;

            for (int i = 0; i < w.Languages.Length; i++)
            {
                dataGridView1.Columns[i].Name = w.Languages[i];
            }

            dataGridView1.Rows.Add();

            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordList w = WordList.LoadList(Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] words = new string[w.Languages.Length];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value != null)
                    {
                        string word = row.Cells[i].Value.ToString();

                        words[i] = word;
                    }
                    else
                    {
                        MessageBox.Show("Fill all the translations to save", "Empty translations", MessageBoxButtons.OK);
                        return;
                    }
                }
                w.Add(words);
            }

            w.Save();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            if (dataGridView1.Rows.Count == 15)
            {
                button3.Enabled = false;
            }
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 2)
            {
                button4.Enabled = false;
            }
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
            button4.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count < 15)
            {
                dataGridView1.Rows.Add();
            }
            button4.Enabled = true;
        }
        
    }
}
