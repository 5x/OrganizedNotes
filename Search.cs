using System;
using System.Windows.Forms;

namespace MyNotes {
    public partial class Search : Form {
        private string filter;
        private bool isMultiparameterFilter;

        public Search() {
            InitializeComponent();
            this.ShowDialog();
        }

        public string Filter {
            get { return filter; }
        }

        private void RejectFormEventHandle(object sender, EventArgs e) {
            Close();
        }

        private void AcceptFormEventHandle(object sender, EventArgs e) {
            filter = "WHERE ";

            FilterByContext();
            FilterByTags();
            FilterByIsFavorite();

            if (!isMultiparameterFilter) {
                filter = null;
            }

            Close();
        }

        private void ApplyMultiparameterOption() {
            if (isMultiparameterFilter) {
                filter += " AND ";
            } else {
                isMultiparameterFilter = true;
            }
        }

        private void FilterByContext() {
            string value = textBox1.Text;

            if (value.Length > 0) {
                const string queryString = "(Name LIKE '%{0}%' OR Content LIKE '%{0}%')";
                string searchContent = value.Replace('\'', '"');

                filter += string.Format(queryString, searchContent);
                ApplyMultiparameterOption();
            }
        }

        private void FilterByTags() {
            string value = textBox2.Text;

            if (value.Length <= 0) {
                return;
            }

            ApplyMultiparameterOption();
            value = value.Replace('\'', '"');
            filter += "(Tags LIKE '%";

            for (int currentIndex = 0; currentIndex < value.Length; currentIndex++) {
                if (value[currentIndex] == ',') {
                    filter += "%' AND Tags LIKE '%";

                    if (currentIndex < value.Length - 1 && value[currentIndex + 1] == ' ') {
                        currentIndex++;
                    }
                } else {
                    filter += value[currentIndex];
                }
            }

            filter += "')";
        }

        private void FilterByIsFavorite() {
            if (checkBox1.Checked) {
                ApplyMultiparameterOption();
                filter += "(isFav = True)";
            }
        }
    }
}
