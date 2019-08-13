using System;
using System.Collections.Generic;

namespace MyNotes {

    class Note {
        private int noteId;
        private int classificationId;
        private int authorId;
        private bool isFavorite;
        private string name;
        private string content;
        private string tags;
        private DateTime createDate;
        private DateTime modifiedDate;

        public int NoteId { get { return noteId; } }
        public int ClassificationId { get { return classificationId; } }
        public int AuthorId { get { return authorId; } }
        public bool IsFavorite { get { return isFavorite; } }
        public string Name { get { return name; } }
        public string Tags { get { return tags; } }
        public string Content { get { return content; } }
        public DateTime CreateDate { get { return createDate; } }
        public DateTime ModifiedDate { get { return modifiedDate; } }

        public Item SelectedNote {
            set {
                if (value.Id > 0 && noteId != value.Id) {
                    noteId = value.Id;
                    name = value.Text;

                    LoadNoteById(noteId);
                }
            }
        }

        private void LoadNoteById(int noteIdValue) {
            const string queryString = "SELECT {0} FROM {1} WHERE {2} = {3};";
            const string columns = @"ClassificationID, AuthorID, Content,
                    Tags, isFav, CreateDate, ModifiedDate";
            const string tableName = "NotesTable";
            const string filterColumn = "ID";

            List<object> list = DataBase.GetList(
                queryString, columns, tableName, filterColumn, noteIdValue);

            if (list != null && list.Count == 7) {
                classificationId = (int)list[0];
                authorId = (int)list[1];
                content = list[2].ToString();
                tags = list[3].ToString();
                isFavorite = (bool)list[4];
                createDate = (DateTime)list[5];
                modifiedDate = (DateTime)list[6];
            }
        }
    }
}
