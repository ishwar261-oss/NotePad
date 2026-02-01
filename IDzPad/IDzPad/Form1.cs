using System.IO; // Required for file operations
using System.Windows.Forms; // Already included

namespace IDzPad
{
    public partial class IDzPad : Form
    {
        public IDzPad()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBoxMain.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBoxMain.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.BackColor = colorDialog1.Color; // Change text area background
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.SelectAll();
        }

        private void fontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.SelectionColor = colorDialog1.Color;
            }
        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.SelectionFont = fontDialog1.Font;
            }
        }
        private void ApplyLightTheme()
        {
            this.BackColor = Color.WhiteSmoke;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;

            textBoxMain.BackColor = Color.White;
            textBoxMain.ForeColor = Color.Black;
        }
        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.BackColor = Color.FromArgb(45, 45, 45);
            menuStrip1.ForeColor = Color.White;

            textBoxMain.BackColor = Color.FromArgb(30, 30, 30);
            textBoxMain.ForeColor = Color.White;
        }
        private void ApplyCustomTheme()
        {
            ColorDialog colorDialog = new ColorDialog();

            // Background
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.BackColor = colorDialog.Color;
                this.BackColor = colorDialog.Color;
            }

            // Text Color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMain.ForeColor = colorDialog.Color;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IDzPad_Load(object sender, EventArgs e)
        {
            ApplyLightTheme();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyLightTheme();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyCustomTheme();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDarkTheme();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMain_SelectionChanged(object sender, EventArgs e)
        {
            //HighlightSyntax();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = textBoxMain.SelectionStart;

            int line = textBoxMain.GetLineFromCharIndex(index);
            int column = index - textBoxMain.GetFirstCharIndexOfCurrentLine();

            lblLine.Text = "Line: " + (line + 1);
            lblColumn.Text = "Column: " + (column + 1);

            lblChars.Text = "Chars: " + textBoxMain.TextLength;
        }
       /* private void HighlightSyntax()
        {
            int selectionStart = textBoxMain.SelectionStart;
            int selectionLength = textBoxMain.SelectionLength;

            textBoxMain.SuspendLayout();

            string text = textBoxMain.Text;

            // Reset all text
            textBoxMain.SelectAll();
            textBoxMain.SelectionColor = textBoxMain.ForeColor;

            // =========================
            // 1️⃣ Multi-line comments /* 
            // =========================
            var multiComments = System.Text.RegularExpressions.Regex.Matches(
                text,
                @"/\*.*?\*/           //mistake",
           /*     System.Text.RegularExpressions.RegexOptions.Singleline
            );

            foreach (System.Text.RegularExpressions.Match match in multiComments)
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.FromArgb(87, 166, 74);
            }

            // =========================
            // 2️⃣ Single-line comments //
            // =========================
            var singleComments = System.Text.RegularExpressions.Regex.Matches(
                text,
                @"//.*?$",
                System.Text.RegularExpressions.RegexOptions.Multiline
            );

            foreach (System.Text.RegularExpressions.Match match in singleComments)
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.FromArgb(87, 166, 74);
            }

            // =========================
            // 3️⃣ Strings "..."
            // =========================
            var stringMatches = System.Text.RegularExpressions.Regex.Matches(
                text,
                "\".*?\""
            );

            foreach (System.Text.RegularExpressions.Match match in stringMatches)
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.FromArgb(214, 157, 133);
            }

            // =========================
            // 4️⃣ Numbers
            // =========================
            var numberMatches = System.Text.RegularExpressions.Regex.Matches(
                text,
                @"\b\d+(\.\d+)?\b"
            );

            foreach (System.Text.RegularExpressions.Match match in numberMatches)
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.FromArgb(181, 206, 168);
            }

            // =========================
            // 5️⃣ Keywords
            // =========================
            string[] keywords =
            {
        "int","string","public","private","class","void","if","else",
        "for","while","return","using","namespace","static","new",
        "bool","true","false","switch","case","break","continue"
    };

            foreach (string keyword in keywords)
            {
                var matches = System.Text.RegularExpressions.Regex.Matches(
                    text,
                    @"\b" + keyword + @"\b"
                );

                foreach (System.Text.RegularExpressions.Match match in matches)
                {
                    textBoxMain.Select(match.Index, match.Length);
                    textBoxMain.SelectionColor = Color.FromArgb(86, 156, 214);
                }
            }

            // =========================
            // 6️⃣ Function Names
            // (word followed by "(" )
            // =========================
            var functionMatches = System.Text.RegularExpressions.Regex.Matches(
                text,
                @"\b[A-Za-z_][A-Za-z0-9_]*(?=\()"
            );

            foreach (System.Text.RegularExpressions.Match match in functionMatches)
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.FromArgb(220, 220, 170);
            }

            // Restore cursor
            textBoxMain.Select(selectionStart, selectionLength);
            textBoxMain.ResumeLayout();
        }
           */


    }
}
