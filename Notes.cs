namespace MyNotes {
    class Notes : Element {
        private string sortBy;
        private bool isReversSorted;
        private bool isSelectedAll;
        private bool searchResult;
        private int classificationIdValue;
        private string currentFilterString;
        private Note note;

        public Notes(string tableName, string sortBy)
            : base(tableName) {
            this.sortBy = sortBy;
            this.isSelectedAll = true;
            note = new Note();
        }

        public Note SelectedNote { get { return note; } }
        public bool SearchResult { set { searchResult = value; } }

        public string CurrentFilterString {
            get { return currentFilterString; }
            set { currentFilterString = value; }
        }

        public bool IsReversSorted {
            get { return isReversSorted; }
            set { isReversSorted = value; }
        }

        public bool IsSelectedAll {
            get { return isSelectedAll; }
            set { isSelectedAll = value; }
        }

        public string SortBy { set { sortBy = value; } }
        public int ClassificationIdValue { set { classificationIdValue = value; } }

        public new void LoadData() {
            string where = "";
            if (!isSelectedAll) {
                if (currentFilterString == null) {
                    return;
                }

                string baseFilterValue = currentFilterString == "isFav" ? "True" : classificationIdValue.ToString();
                where = string.Format("WHERE {0} = {1}", currentFilterString, baseFilterValue);
            }

            if (searchResult) {
                where = currentFilterString;
            }

            const string queryString = "SELECT {0}, {1} FROM {2} {3} ORDER BY {4} {5}";
            string order = isReversSorted ? "DESC" : "ASC";

            base.Parse(queryString, RowIdText, RowNameText, TableName, where, sortBy, order);
        }

        public void Create(int categoryId, int authorId, string text) {
            text = "'" + text.Replace('\'', '"') + "'";

            base.Add("ClassificationID", categoryId.ToString(), "AuthorID",
                authorId.ToString(), RowNameText, text);

            items.Add(base.LastID, text);
        }

        public void Update(string name, string text) {
            name = "'" + name + "'";
            text = "'" + text + "'";

            string currentDateTimeString = getCurrentDateTimeString();
            base.Update(note.NoteId, RowNameText, name, "Content", text,
                "ModifiedDate", currentDateTimeString);
        }

        public void Update(string row, string value, bool isStringValue) {
            if (isStringValue) {
                value = value.Replace('\'', '"');
                value = "'" + value + "'";
            }

            string currentDateTimeString = getCurrentDateTimeString();
            base.Update(note.NoteId, row, value, "ModifiedDate", currentDateTimeString);
        }

        public void Delete() {
            int noteId = SelectedNote.NoteId;
            base.Delete(noteId);
        }

        private string getCurrentDateTimeString() {
            System.DateTime currentDateTime = System.DateTime.Now;
            return "'" + currentDateTime + "'";
        }
    }

}
