using System.Windows.Forms;

namespace MyNotes {
    public static class PromptDialog {
        private static bool _isReadyToAccept;
        private static Form _prompt;

        public static string ShowDialog(string text) {
            _isReadyToAccept = false;

            _prompt = new Form() {
                Width = 235,
                Height = 110,
                Text = text,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            };

            TextBox textBox = new TextBox() { Left = 12, Top = 12, Width = 200 };
            Button ok = new Button() { Text = "Ok", Left = 12, Top = 35 };

            ok.Click += (sender, e) => { _isReadyToAccept = true; _prompt.Close(); };
            textBox.KeyDown += DialogKeyHandle;

            _prompt.Controls.Add(ok);
            _prompt.Controls.Add(textBox);
            _prompt.ShowDialog();

            if (_isReadyToAccept && textBox.Text.Length > 0) {
                return textBox.Text;
            } else {
                return null;
            }
        }

        static void DialogKeyHandle(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Enter:
                    _isReadyToAccept = true;
                    _prompt.Close();
                    break;
                case Keys.Escape:
                    _prompt.Close();
                    break;
            }
        }

    }
}
