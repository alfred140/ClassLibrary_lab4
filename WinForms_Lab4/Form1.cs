using ClassLibrary_lab4;
using System;
using System.IO;
using System.Windows.Forms;


namespace WinForms_Lab4
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();
            deleteList.Enabled = false;
            deleteWord.Enabled = false;
            addWord.Enabled = false;
            label3.Visible = false;
            

            foreach (string str in WordList.GetLists())
            {
                listViewer.Items.Add(Path.GetFileNameWithoutExtension(str));
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string removeThis = wordGrid.CurrentCell.Value.ToString();
            WordList listremover = WordList.LoadList(listViewer.SelectedItem.ToString());

            int lang = wordGrid.CurrentCell.ColumnIndex;

            DialogResult message = MessageBox.Show(removeThis + " and its translations will be removed.", "Removing words", MessageBoxButtons.OKCancel);

            if (message == DialogResult.OK)
            {
                listremover.Remove(lang, removeThis);
                listremover.Save();
                wordGrid.Rows.Clear();
                Action<string[]> action = new Action<string[]>(LoadWords);
                string listName = listViewer.SelectedItem.ToString();

                WordList.LoadList(listName).List(0, action);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int selectedList = listViewer.SelectedIndex;
            ListForm f = new ListForm();
            f.ShowDialog();
            listViewer.Items.Clear();
            foreach (string str in WordList.GetLists())
            {
                listViewer.Items.Add(Path.GetFileNameWithoutExtension(str));
            }

            try
            {
                listViewer.SetSelected(selectedList, true);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult message = MessageBox.Show("Delete the following list? " + listViewer.SelectedItem.ToString(), "Removing list", MessageBoxButtons.OKCancel);
            

            if (message == DialogResult.OK)
            {
                File.Delete(path: Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\lab4\" + listViewer.SelectedItem.ToString() + ".dat");
                listViewer.Items.Clear();
                foreach (string str in WordList.GetLists())
                {
                    listViewer.Items.Add(Path.GetFileNameWithoutExtension(str));
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string listName = "";

            wordGrid.Rows.Clear();
            Action<string[]> action = new Action<string[]>(LoadWords);
            if (listViewer.SelectedItem != null)
            {
                listName = listViewer.SelectedItem.ToString();

                deleteWord.Enabled = true;
                deleteList.Enabled = true;
                addWord.Enabled = true;
                

                WordList w = WordList.LoadList(listName);

                wordGrid.ColumnCount = w.Languages.Length;

                for (int i = 0; i < w.Languages.Length; i++)
                {
                    wordGrid.Columns[i].Name = w.Languages[i];
                }

                w.List(0, action);

                label3.Text = "Word count: " + wordGrid.Rows.Count.ToString();
                label3.Visible = true;

                if(wordGrid.Rows.Count < 1)
                {
                    deleteWord.Enabled = false;
                    
                }
                

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            WordForm form = new WordForm();
            form.Text = listViewer.SelectedItem.ToString();
            form.ShowDialog();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        
        private void LoadWords(string[] translations)
        {
            wordGrid.Rows.Add(translations);
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
