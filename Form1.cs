using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyNotes {
    public partial class Form1 : Form {
        private Authors authors;
        private Classifications classifications;
        private Notes notes;

        public Form1() {
            InitializeComponent();

            DataBase.CreateConnectionString("NotesDB.mdb");
            authors = new Authors("AuthorTable");
            classifications = new Classifications("ClassificationTable");
            notes = new Notes("NotesTable", "ID");
            LoadDataToElement();
        }

        private void LoadDataToElement() {
            FillToolStrip(authors, authorMenuItem);
            FillToolStrip(classifications, clasifMenuItem);
            fillComboBox(classifications, comboBox1);
            fillComboBox(authors, comboBox2);

            comboBox1.DisplayMember = comboBox2.DisplayMember = "Text";
            SelectData(true);
        }

        private void fillComboBox(Element e, ComboBox item) {
            foreach (Item i in e.Items) {
                item.Items.Add(i);
            }
        }

        private void FillToolStrip(Element e, ToolStripMenuItem item) {
            foreach (var i in e.Items) {
                item.DropDownItems.Add(i.Text, null, MenuClick);
            }
        }

        private void NoteView(int index) {
            if (!notes.Items.RangeEntry(index)) {
                return;
            }

            notes.SelectedNote.SelectedNote = notes.Items[index];
            label1.Text = notes.SelectedNote.CreateDate + " / " + notes.SelectedNote.ModifiedDate;
            checkBox1.Checked = notes.SelectedNote.IsFavorite;
            textBox1.Text = notes.SelectedNote.Tags;
            comboBox1.SelectedIndex = classifications.Items.FindIndex(notes.SelectedNote.ClassificationId);
            comboBox2.SelectedIndex = authors.Items.FindIndex(notes.SelectedNote.AuthorId);
            richTextBox1.Text = notes.SelectedNote.Name + "\n" + notes.SelectedNote.Content;
            RichTextBoxUpdate(richTextBox1.Lines[0].Length + 1);
        }

        private void SelectData(bool load) {
            int index = listBox1.SelectedIndex;

            if (load) {
                LeaveFocus();
                notes.LoadData();
                index = -1;
            }

            UpdateListBox(listBox1);

            if (notes.Items == null || notes.Items.Count < 1) {
                NothingSelected();
            } else {
                label2.Text = "Всего заметок: " + notes.Items.Count;

                if (index >= notes.Items.Count) {
                    index = notes.Items.Count - 1;
                }

                listBox1.SelectedIndex = index < 0 ? 0 : index;
            }
        }

        private void UpdateListBox(ListBox listBox) {
            listBox.BeginUpdate();
            listBox.DataSource = null;
            listBox.DataSource = notes.Items;
            listBox.DisplayMember = "Text";
            listBox.EndUpdate();
        }

        private int toolStripIndexFind(ToolStripMenuItem item) {
            for (int i = 0; i < item.DropDownItems.Count; i++) {
                if (((ToolStripMenuItem)item.DropDownItems[i]).Checked) {
                    return i;
                }
            }

            return 0;
        }

        private void NothingSelected() {
            if (clasifMenuItem.Checked) {
                comboBox1.SelectedIndex = classifications.Items.FindIndex(toolStripIndexFind(clasifMenuItem));
            } else if (authorMenuItem.Checked) {
                comboBox2.SelectedIndex = classifications.Items.FindIndex(toolStripIndexFind(authorMenuItem));
            }

            label2.Text = "Невдалося нічого знайти";
            richTextBox1.Text = "Тут порожньо.\nСтворіть новий нотаток.";
            textBox1.Text = "";

            RichTextBoxUpdate(0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            var textBox = (sender as TextBox);
            if (textBox == null) {
                return;
            }

            string value = textBox.Text;
            int startPosition = textBox.SelectionStart;

            if (startPosition > 0 && (e.KeyChar == ',' || e.KeyChar == ' ')) {
                if (value[startPosition - 1] != ',' && value[startPosition - 1] != ' ') {
                    textBox.Text = value.Insert(startPosition, ", ");
                    textBox.SelectionStart = startPosition + 2;
                }
            }

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void CreateItem(string text, Element e, ToolStripMenuItem menuItem, ComboBox comboBox) {
            string value = PromptDialog.ShowDialog(text);

            if (e.Add(value)) {
                menuItem.DropDownItems.Add(value, null, MenuClick);
                comboBox.Items.Add(e.Items[e.Items.Count - 1]);
            }
        }

        private void ChangeInedexOnCombobox(int index, int id, string row) {
            if (notes.Items.RangeEntry(index) && index != id) {
                notes.Update(row, index.ToString(), false);

                if (notes.CurrentFilterString == row && notes.Items.RangeEntry(listBox1.SelectedIndex)) {
                    notes.Items.RemoveAt(listBox1.SelectedIndex);
                    SelectData(false);
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e) {
            bool value = ((CheckBox)sender).Checked;

            if (notes.Items.Count > 0) {
                notes.Update("isFav", value.ToString(), false);

                if (!notes.IsSelectedAll && notes.CurrentFilterString == "isFav") {
                    SelectData(true);
                }
            }
        }

        private void ListBoxSelectedIndexChanged(object sender, EventArgs e) {
            if (notes.Items != null && notes.Items.Count > 0) {
                ListBox listBox = sender as ListBox;

                if (listBox != null) {
                    NoteView(listBox.SelectedIndex);
                }
            }
        }

        private void uncheckedItem(ToolStripMenuItem item) {
            foreach (var i in item.Owner.Items) {
                if (i.GetType() != typeof(ToolStripMenuItem)) {
                    return;
                }

                ((ToolStripMenuItem)i).Checked = false;
            }
        }

        private void UncheckedAll() {
            foreach (ToolStripMenuItem item in viewMenuItem.DropDownItems) {
                foreach (ToolStripMenuItem dropItem in item.DropDownItems) {
                    dropItem.Checked = false;
                }

                item.Checked = false;
            }
        }

        private void SortTypeSet(string sortBy, ToolStripMenuItem item) {
            if (!item.Checked) {
                uncheckedItem(item);
                item.Checked = true;
                notes.SortBy = sortBy;

                SelectData(true);
            }
        }

        private void SortReversSet(bool revers) {
            if (notes.IsReversSorted != revers) {
                sortDownMenuItem.Checked = notes.IsReversSorted = revers;
                sortUpMenuItem.Checked = !revers;

                SelectData(true);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            Search searchForm = new Search();

            if (!string.IsNullOrWhiteSpace(searchForm.Filter)) {
                ToolStripMenuItem menuItem = (sender as ToolStripMenuItem);

                if (menuItem == null) {
                    return;
                }

                menuItem.Checked = true;
                GetSearchResult(searchForm.Filter);
            }
        }

        private void GetSearchResult(string searchFilter) {
            UncheckedAll();
            notes.CurrentFilterString = searchFilter;
            notes.SearchResult = true;
            SelectData(true);
            notes.SearchResult = false;
        }

        private void AddNote(object sender, EventArgs e) {
            int classificationId = classifications.Items[comboBox1.SelectedIndex].Id;
            int authorId = authors.Items[comboBox2.SelectedIndex].Id;

            notes.Create(classificationId, authorId, "Нова нотатка");

            SelectData(false);
            listBox1.SelectedIndex = notes.Items.Count - 1;
        }

        private void createAutorMenuItem_Click(object sender, EventArgs e) {
            CreateItem("Створення нового автора", authors, authorMenuItem, comboBox2);
        }

        private void addCatMenuItem_Click(object sender, EventArgs e) {
            CreateItem("Нова класифікація", classifications, clasifMenuItem, comboBox1);
        }

        private void NoteDeleteEvent(object sender, EventArgs e) {
            notes.Delete();
            SelectData(false);
        }

        private void ComboBox1IndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox == null) {
                return;
            }

            int selectedClassificationsMenuId = classifications.Items[comboBox.SelectedIndex].Id;
            int classificationId = notes.SelectedNote.ClassificationId;

            ChangeInedexOnCombobox(selectedClassificationsMenuId, classificationId, "ClassificationID");
        }

        private void ComboBox2IndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = (sender as ComboBox);

            if (comboBox == null) {
                return;
            }

            int selectedIndex = comboBox.SelectedIndex;
            int selectedAuthorMenuId = authors.Items[selectedIndex].Id;
            int authorId = notes.SelectedNote.AuthorId;

            ChangeInedexOnCombobox(selectedAuthorMenuId, authorId, "AuthorID");
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            if (notes.Items.Count > 0 && textBox1.Text != notes.SelectedNote.Tags) {
                notes.Update("Tags", textBox1.Text, true);
            }
        }

        private void NextNote(object sender, EventArgs e) {
            if (notes.Items != null && notes.Items.Count > 0 && listBox1.SelectedIndex < notes.Items.Count - 1) {
                listBox1.SelectedIndex++;
            }
        }

        private void PrevNote(object sender, EventArgs e) {
            if (listBox1.SelectedIndex > 0) {
                listBox1.SelectedIndex--;
            }
        }

        private void sortUpMenu_Click(object sender, EventArgs e) {
            SortReversSet(false);
        }

        private void sortDownMenuItem_Click(object sender, EventArgs e) {
            SortReversSet(true);
        }

        private void LeaveFocus() {
            this.Select();
            this.textBox1.Select();
            this.richTextBox1.Select();
        }

        private void saveToolItem_Click(object sender, EventArgs e) {
            LeaveFocus();
        }

        private void sortByIdMenuItem_Click(object sender, EventArgs e) {
            SortTypeSet("ID", (ToolStripMenuItem)sender);
        }

        private void changeDateMenuItem_Click(object sender, EventArgs e) {
            SortTypeSet("ModifiedDate", (ToolStripMenuItem)sender);
        }

        private void createDateMenuItem_Click(object sender, EventArgs e) {
            SortTypeSet("CreateDate", (ToolStripMenuItem)sender);
        }

        private void subSortMenuItem_Click(object sender, EventArgs e) {
            SortTypeSet("Name", (ToolStripMenuItem)sender);
        }

        private void MenuClick(object sender, EventArgs e) {
            var toolMenu = (ToolStripMenuItem)sender;
            if (toolMenu.Checked) {
                return;
            }

            UncheckedAll();

            var parentTool = (ToolStripMenuItem)toolMenu.OwnerItem;
            toolMenu.Checked = parentTool.Checked = true;

            int currentId = 0;
            while (toolMenu.Text != parentTool.DropDownItems[currentId].Text) {
                currentId++;
            }
            currentId--;

            string value = parentTool.Name;
            if (value == viewMenuItem.Name) {
                value = toolMenu.Name;
            }

            notes.IsSelectedAll = false;

            switch (value) {
                case "clasifMenuItem":
                    notes.ClassificationIdValue = classifications.Items[currentId].Id;
                    notes.CurrentFilterString = "ClassificationID";
                    break;
                case "authorMenuItem":
                    notes.ClassificationIdValue = authors.Items[currentId].Id;
                    notes.CurrentFilterString = "AuthorID";
                    break;
                case "favMenuItem":
                    notes.CurrentFilterString = "isFav";
                    break;
                default:
                    notes.IsSelectedAll = true;
                    break;
            }

            SelectData(true);
        }

        private void DrawSelectedText(int start, int len, Font font) {
            richTextBox1.Select(start, len);
            richTextBox1.SelectionFont = font;
        }

        private string HeaderCut(int maxLength, string value) {
            if (richTextBox1.Lines[0].Length > maxLength) {
                int lastDelimeterPosition = richTextBox1.Text.LastIndexOf(" ", maxLength, StringComparison.Ordinal);
                lastDelimeterPosition = lastDelimeterPosition > 0 ? lastDelimeterPosition : maxLength;
                value = richTextBox1.Text.Insert(lastDelimeterPosition, "\n");
            }

            return value;
        }

        private void RichTextBoxUpdate(int carretPos) {
            if (richTextBox1.Lines.Length > 0) {
                if (richTextBox1.Lines[0].Length > 100) {
                    richTextBox1.Text = HeaderCut(100, richTextBox1.Text);
                    carretPos++;
                }

                DrawSelectedText(richTextBox1.Lines[0].Length, richTextBox1.Text.Length, richTextBox1.Font);
                DrawSelectedText(0, richTextBox1.Lines[0].Length, new Font(richTextBox1.Font.FontFamily, 14));
                DrawSelectedText(carretPos, 0, richTextBox1.Font);
            }
        }

        private void SaveChangesEvent(object sender, EventArgs e) {
            if (notes.Items == null || notes.Items.Count <= 0) {
                return;
            }

            string value = richTextBox1.Text.Trim(' ', '\n').Replace('\'', '"');
            string cuttedHeader = HeaderCut(100, value);
            string text = "";

            if (cuttedHeader.Length <= 0) {
                notes.Delete();
                SelectData(false);

                return;
            }

            int titleLength = cuttedHeader.IndexOf('\n');
            if (titleLength > 0) {
                text = cuttedHeader.Substring(titleLength + 1, cuttedHeader.Length - titleLength - 1);
            } else {
                titleLength = cuttedHeader.Length;
            }

            string title = cuttedHeader.Substring(0, titleLength);
            if (title == notes.SelectedNote.Name && text == notes.SelectedNote.Content) {
                return;
            }

            notes.Update(title, text);

            if (title != notes.SelectedNote.Name) {
                notes.Items[listBox1.SelectedIndex] = new Item(notes.SelectedNote.NoteId, title);
                SelectData(false);
            }
        }

        private void ReRenderTextBoxOnPasteHandle(object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.V && e.Modifiers == Keys.Control) ||
               (e.KeyCode == Keys.Enter && richTextBox1.SelectionStart <= 100) ||
               richTextBox1.Lines.Length > 0 && richTextBox1.Lines[0].Length > 100) {
                RichTextBoxUpdate(richTextBox1.SelectionStart);
            }
        }

        private void ControllTitleDeleteBehaviorKeyHandle(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Back && richTextBox1.Lines[0].Length == richTextBox1.SelectionStart - 1) {
                e.Handled = true;
            }
        }
    }

}
