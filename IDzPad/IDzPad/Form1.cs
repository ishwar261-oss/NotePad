using System.Diagnostics;
using System.IO; 
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IDzPad
{
    public partial class IDzPad : Form
    {
        public IDzPad()
        {
            InitializeComponent();
        }

        string currentLanguage;


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

            string ext = Path.GetExtension(openFileDialog1.FileName);

            switch (ext)
            {
                case ".cs": currentLanguage = "CSharp"; break;
                case ".py": currentLanguage = "Python"; break;
                case ".cpp": currentLanguage = "Cpp"; break;
                case ".java": currentLanguage = "Java"; break;
                case ".sql": currentLanguage = "SQL"; break;
                case ".html": currentLanguage = "HTML"; break;
            }

        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
            lblLang.Text = "";
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
            HighlightSyntax();
           
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

        private void clangToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentLanguage = "C";
            HighlightSyntax();
            textBoxMain.Clear();
            lblLang.Text = "Language Selected :  C";
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "Java";
            HighlightSyntax();
            textBoxMain.Clear();
            lblLang.Text = "Language Selected :  Java";
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "Python";
            HighlightSyntax();
            textBoxMain.Clear();
            lblLang.Text = "Language Selected :  Python";

        }

        private void sQlPLSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "SQL";
            HighlightSyntax();
            textBoxMain.Clear();
            lblLang.Text = "Language Selected :  SQL";
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "CSharp";
            HighlightSyntax();
            textBoxMain.Clear();
            lblLang.Text = "Language Selected :  C#";
        }

        private void cppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "Cpp";

            HighlightSyntax();

            
                textBoxMain.Clear();
            lblLang.Text = "Language Selected :  Cpp";

        }
        private void HighlightSyntax()
        {
            int selectionStart = textBoxMain.SelectionStart;
            int selectionLength = textBoxMain.SelectionLength;

            // Reset all text color first
            textBoxMain.SelectAll();
            textBoxMain.SelectionColor = textBoxMain.ForeColor;

            string[] keywords = { };

            if (currentLanguage == "CSharp")
            {
                keywords = new string[] {
            "int","string","public","private","class",
            "void","using","namespace","return","new"
        };
            }
            else if (currentLanguage == "Python")
            {
                keywords = new string[] {
            "def","import","return","if","else",
            "while","for","class","print"
        };
            }
            else if (currentLanguage == "Cpp")
            {
                keywords = new string[] {
            "public","private","class","void",
            "int","new","return","static","include","cin","cout","#"
        };
            }
            else if (currentLanguage == "Java")
            {
                keywords = new string[] {
            "public","private","class","void",
            "int","new","return","static","Import"
        };
            }
            else if (currentLanguage == "SQL")
            {
                keywords = new string[] {
            "select","from","where","insert",
            "update","delete","create","table"
        };
            }
            else if (currentLanguage == "C")
            {
                keywords = new string[] {
            "int","char","printf","scanf",
            "return","void","if","else"
        };
            }

            // Highlight keywords
            foreach (string word in keywords)
            {
                foreach (Match match in Regex.Matches(
                    textBoxMain.Text, @"\b" + word + @"\b"))
                {
                    textBoxMain.Select(match.Index, match.Length);
                    textBoxMain.SelectionColor = Color.Blue;
                }
            }

            // Strings
            foreach (Match match in Regex.Matches(textBoxMain.Text, "\".*?\""))
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.Orange;
            }

            // Comments
            foreach (Match match in Regex.Matches(
                textBoxMain.Text, @"//.*?$",
                RegexOptions.Multiline))
            {
                textBoxMain.Select(match.Index, match.Length);
                textBoxMain.SelectionColor = Color.DarkGreen;
            }

            // Restore cursor
            textBoxMain.SelectionStart = selectionStart;
            textBoxMain.SelectionLength = selectionLength;
        }

        private void textBoxMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '(')
            {
                textBoxMain.SelectedText = "()";
                textBoxMain.SelectionStart--;
                e.Handled = true;
            }
            else if (e.KeyChar == '{')
            {
                textBoxMain.SelectedText = "{}";
                textBoxMain.SelectionStart--;
                e.Handled = true;
            }
            else if (e.KeyChar == '[')
            {
                textBoxMain.SelectedText = "[]";
                textBoxMain.SelectionStart--;
                e.Handled = true;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                //  Save_File();
                return true;
            }

            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("Find Feature Coming Soon 😎");
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                textBoxMain.Clear();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBoxMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int line = textBoxMain.GetLineFromCharIndex(
                    textBoxMain.SelectionStart);

                if (line > 0)
                {
                    string prevLine = textBoxMain.Lines[line - 1];
                    string indent =
                        new string(' ',
                        prevLine.TakeWhile(Char.IsWhiteSpace).Count());

                    textBoxMain.SelectedText = "\n" + indent;
                    e.Handled = true;
                }
            }

        }

        private void rUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOutput.Visible = true;

            string tempPath = Path.Combine(
                Application.StartupPath,
                "tempcode");

            if (currentLanguage == "Cpp")
            {
                File.WriteAllText(tempPath + ".cpp", textBoxMain.Text);
                RunCpp(tempPath);
            }
            else if (currentLanguage == "Java")
            {
                File.WriteAllText(tempPath + ".java", textBoxMain.Text);
                RunJava(tempPath);
            }
            else if (currentLanguage == "CSharp")
            {
                File.WriteAllText(tempPath + ".cs", textBoxMain.Text);
                RunCSharp(tempPath);
            }
        }
        private void RunCpp(string path)
        {
            foreach (var process in Process.GetProcessesByName("tempcode"))
            {
                process.Kill();
            }
            string compileCmd =
                "/c g++ \"" + path + ".cpp\" -o \"" +
                path + ".exe\" && \"" + path + ".exe\"";

            RunCommand(compileCmd);
        }
        private void RunJava(string path)
        {
            string cmd =
                "/c javac \"" + path + ".java\" && java tempcode";

            RunCommand(cmd);
        }
        private void RunCSharp(string path)
        {
            string cmd =
                "/c csc \"" + path + ".cs\" && tempcode.exe";

            RunCommand(cmd);
        }
        private void RunCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = command;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();

            p.WaitForExit();

            txtOutput.Text = output + "\n" + error;
        }

        private void btnOutputClose_Click(object sender, EventArgs e)
        {
            panelOutput.Visible = false;
        }
    }
}
