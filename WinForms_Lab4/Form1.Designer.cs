namespace WinForms_Lab4
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wordGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addList = new System.Windows.Forms.Button();
            this.deleteList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteWord = new System.Windows.Forms.Button();
            this.addWord = new System.Windows.Forms.Button();
            this.listViewer = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordGrid
            // 
            this.wordGrid.AllowUserToAddRows = false;
            this.wordGrid.AllowUserToDeleteRows = false;
            this.wordGrid.AllowUserToResizeRows = false;
            this.wordGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wordGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.wordGrid.Location = new System.Drawing.Point(247, 57);
            this.wordGrid.MultiSelect = false;
            this.wordGrid.Name = "wordGrid";
            this.wordGrid.ReadOnly = true;
            this.wordGrid.RowHeadersVisible = false;
            this.wordGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.wordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.wordGrid.Size = new System.Drawing.Size(380, 239);
            this.wordGrid.TabIndex = 3;
            this.wordGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select list";
            // 
            // addList
            // 
            this.addList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addList.Location = new System.Drawing.Point(22, 226);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(75, 23);
            this.addList.TabIndex = 9;
            this.addList.Text = "New list";
            this.addList.UseVisualStyleBackColor = true;
            this.addList.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteList
            // 
            this.deleteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteList.Location = new System.Drawing.Point(112, 226);
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(75, 23);
            this.deleteList.TabIndex = 10;
            this.deleteList.Text = "Delete list";
            this.deleteList.UseVisualStyleBackColor = true;
            this.deleteList.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Words:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "word counter";
            // 
            // deleteWord
            // 
            this.deleteWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteWord.Location = new System.Drawing.Point(328, 315);
            this.deleteWord.Name = "deleteWord";
            this.deleteWord.Size = new System.Drawing.Size(75, 23);
            this.deleteWord.TabIndex = 0;
            this.deleteWord.Text = "Delete word";
            this.deleteWord.UseVisualStyleBackColor = true;
            this.deleteWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // addWord
            // 
            this.addWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addWord.Location = new System.Drawing.Point(247, 315);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(75, 23);
            this.addWord.TabIndex = 12;
            this.addWord.Text = "Add word";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.button4_Click);
            // 
            // listViewer
            // 
            this.listViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewer.FormattingEnabled = true;
            this.listViewer.Location = new System.Drawing.Point(22, 57);
            this.listViewer.Name = "listViewer";
            this.listViewer.Size = new System.Drawing.Size(165, 160);
            this.listViewer.TabIndex = 11;
            this.listViewer.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.practiceToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Checked = true;
            this.editorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.practiceToolStripMenuItem.Text = "Practice";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewer);
            this.Controls.Add(this.deleteList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addList);
            this.Controls.Add(this.deleteWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addWord);
            this.Controls.Add(this.wordGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "Wordlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView wordGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.Button deleteList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteWord;
        private System.Windows.Forms.Button addWord;
        private System.Windows.Forms.ListBox listViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

