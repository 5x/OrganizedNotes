namespace MyNotes {
    partial class Form1 {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notesMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasifMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAutorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByIdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modDateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subSortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1MinSize = 35;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(504, 341);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Location = new System.Drawing.Point(10, 5);
            this.listBox1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(484, 65);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panel3.Size = new System.Drawing.Size(504, 25);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 23);
            this.panel4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(444, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PrevNote);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(469, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NextNote);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(14, 12);
            this.richTextBox1.MaxLength = 500000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(480, 218);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControllTitleDeleteBehaviorKeyHandle);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReRenderTextBoxOnPasteHandle);
            this.richTextBox1.Leave += new System.EventHandler(this.SaveChangesEvent);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesMenuToolStripMenuItem,
            this.viewMenuItem,
            this.sortMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // notesMenuToolStripMenuItem
            // 
            this.notesMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.DeleteNoteToolStripMenuItem});
            this.notesMenuToolStripMenuItem.Name = "notesMenuToolStripMenuItem";
            this.notesMenuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.notesMenuToolStripMenuItem.Text = "Нотатки";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addNoteToolStripMenuItem.Text = "Додати запис";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNote);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolItem_Click);
            // 
            // DeleteNoteToolStripMenuItem
            // 
            this.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem";
            this.DeleteNoteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteNoteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.DeleteNoteToolStripMenuItem.Text = "Видалити";
            this.DeleteNoteToolStripMenuItem.Click += new System.EventHandler(this.NoteDeleteEvent);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allNotesToolStripMenuItem,
            this.favMenuItem,
            this.clasifMenuItem,
            this.authorMenuItem,
            this.searchMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(89, 20);
            this.viewMenuItem.Text = "Відображати";
            // 
            // allNotesToolStripMenuItem
            // 
            this.allNotesToolStripMenuItem.Checked = true;
            this.allNotesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allNotesToolStripMenuItem.Name = "allNotesToolStripMenuItem";
            this.allNotesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.allNotesToolStripMenuItem.Text = "Весь список";
            this.allNotesToolStripMenuItem.Click += new System.EventHandler(this.MenuClick);
            // 
            // favMenuItem
            // 
            this.favMenuItem.Name = "favMenuItem";
            this.favMenuItem.Size = new System.Drawing.Size(153, 22);
            this.favMenuItem.Text = "Улюблене";
            this.favMenuItem.Click += new System.EventHandler(this.MenuClick);
            // 
            // clasifMenuItem
            // 
            this.clasifMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCatMenuItem});
            this.clasifMenuItem.Name = "clasifMenuItem";
            this.clasifMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clasifMenuItem.Text = "Класифікації";
            // 
            // addCatMenuItem
            // 
            this.addCatMenuItem.Name = "addCatMenuItem";
            this.addCatMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addCatMenuItem.Text = "Додати категорію";
            this.addCatMenuItem.Click += new System.EventHandler(this.addCatMenuItem_Click);
            // 
            // authorMenuItem
            // 
            this.authorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAutorMenuItem});
            this.authorMenuItem.Name = "authorMenuItem";
            this.authorMenuItem.Size = new System.Drawing.Size(153, 22);
            this.authorMenuItem.Text = "Автори";
            // 
            // createAutorMenuItem
            // 
            this.createAutorMenuItem.Name = "createAutorMenuItem";
            this.createAutorMenuItem.Size = new System.Drawing.Size(166, 22);
            this.createAutorMenuItem.Text = "Створити автора";
            this.createAutorMenuItem.Click += new System.EventHandler(this.createAutorMenuItem_Click);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchMenuItem.Size = new System.Drawing.Size(153, 22);
            this.searchMenuItem.Text = "Пошук";
            this.searchMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sortMenuItem
            // 
            this.sortMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByIdMenuItem,
            this.modDateMenuItem,
            this.createDateMenuItem,
            this.subSortMenuItem,
            this.toolStripSeparator1,
            this.sortUpMenuItem,
            this.sortDownMenuItem});
            this.sortMenuItem.Name = "sortMenuItem";
            this.sortMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sortMenuItem.Text = "Сортувати за";
            // 
            // sortByIdMenuItem
            // 
            this.sortByIdMenuItem.Checked = true;
            this.sortByIdMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortByIdMenuItem.Name = "sortByIdMenuItem";
            this.sortByIdMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sortByIdMenuItem.Text = "Ідентифікатором";
            this.sortByIdMenuItem.Click += new System.EventHandler(this.sortByIdMenuItem_Click);
            // 
            // modDateMenuItem
            // 
            this.modDateMenuItem.Name = "modDateMenuItem";
            this.modDateMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modDateMenuItem.Text = "Датою зміни";
            this.modDateMenuItem.Click += new System.EventHandler(this.changeDateMenuItem_Click);
            // 
            // createDateMenuItem
            // 
            this.createDateMenuItem.Name = "createDateMenuItem";
            this.createDateMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createDateMenuItem.Text = "Датою створення";
            this.createDateMenuItem.Click += new System.EventHandler(this.createDateMenuItem_Click);
            // 
            // subSortMenuItem
            // 
            this.subSortMenuItem.Name = "subSortMenuItem";
            this.subSortMenuItem.Size = new System.Drawing.Size(170, 22);
            this.subSortMenuItem.Text = "Им\'ям";
            this.subSortMenuItem.Click += new System.EventHandler(this.subSortMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // sortUpMenuItem
            // 
            this.sortUpMenuItem.Checked = true;
            this.sortUpMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortUpMenuItem.Name = "sortUpMenuItem";
            this.sortUpMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sortUpMenuItem.Text = "За збільшенням";
            this.sortUpMenuItem.Click += new System.EventHandler(this.sortUpMenu_Click);
            // 
            // sortDownMenuItem
            // 
            this.sortDownMenuItem.Name = "sortDownMenuItem";
            this.sortDownMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sortDownMenuItem.Text = "За убування";
            this.sortDownMenuItem.Click += new System.EventHandler(this.sortDownMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1IndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2IndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата створення";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 60);
            this.panel2.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(267, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Додати до улюбленого";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 425);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Класифіковані нотатки";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasifMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modDateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subSortMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortUpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDownMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByIdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAutorMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem allNotesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem notesMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteNoteToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
