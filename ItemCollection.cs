using System.Collections.Generic;

namespace MyNotes {
    struct Item {
        private int id;
        private string text;

        public int Id { get { return id; } }
        public string Text { get { return text; } }

        public Item(int id, string text) {
            this.id = id;
            this.text = text;
        }
    }

    class ItemCollection : List<Item> {
        public void Add(int id, string text) {
            Item item = new Item(id, text);
            Add(item);
        }

        public bool RangeEntry(int index) {
            return index >= 0 && index < Count;
        }

        public int FindIndex(int id) {
            return FindIndex(item => item.Id == id);
        }
    }
}
