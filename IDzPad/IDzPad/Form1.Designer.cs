namespace IDzPad
{
    partial class IDzPad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlheader = new Panel();
            lblTitle = new Label();
            btnMinimize = new Button();
            btnClose = new Button();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            fromatToolStripMenuItem = new ToolStripMenuItem();
            fontStyleToolStripMenuItem = new ToolStripMenuItem();
            fontColourToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            customToolStripMenuItem = new ToolStripMenuItem();
            backgroundColourToolStripMenuItem = new ToolStripMenuItem();
            restoreToDefaultToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            textBoxMain = new RichTextBox();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            lblLine = new ToolStripStatusLabel();
            lblColumn = new ToolStripStatusLabel();
            lblChars = new ToolStripStatusLabel();
            label1 = new Label();
            pnlheader.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlheader
            // 
            pnlheader.BackColor = Color.FromArgb(45, 45, 48);
            pnlheader.Controls.Add(lblTitle);
            pnlheader.Controls.Add(btnMinimize);
            pnlheader.Controls.Add(btnClose);
            pnlheader.Dock = DockStyle.Top;
            pnlheader.Location = new Point(0, 0);
            pnlheader.Name = "pnlheader";
            pnlheader.Size = new Size(1920, 40);
            pnlheader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(45, 45, 48);
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(935, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "IDzPad";
            // 
            // btnMinimize
            // 
            btnMinimize.AutoSize = true;
            btnMinimize.BackColor = Color.FromArgb(45, 45, 48);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Impact", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1820, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 41);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(45, 45, 48);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1859, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 41);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, editToolStripMenuItem1, fromatToolStripMenuItem, settingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 43);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(330, 31);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, saveToolStripMenuItem1, saveAsToolStripMenuItem, exitToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(54, 27);
            editToolStripMenuItem.Text = "File ";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(152, 28);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(152, 28);
            saveToolStripMenuItem.Text = "Open";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(152, 28);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(152, 28);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(152, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(53, 27);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(163, 28);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(163, 28);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(163, 28);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(163, 28);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // fromatToolStripMenuItem
            // 
            fromatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontStyleToolStripMenuItem, fontColourToolStripMenuItem });
            fromatToolStripMenuItem.Name = "fromatToolStripMenuItem";
            fromatToolStripMenuItem.Size = new Size(78, 27);
            fromatToolStripMenuItem.Text = "Fromat";
            // 
            // fontStyleToolStripMenuItem
            // 
            fontStyleToolStripMenuItem.Name = "fontStyleToolStripMenuItem";
            fontStyleToolStripMenuItem.Size = new Size(184, 28);
            fontStyleToolStripMenuItem.Text = "Font Style";
            fontStyleToolStripMenuItem.Click += fontStyleToolStripMenuItem_Click;
            // 
            // fontColourToolStripMenuItem
            // 
            fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            fontColourToolStripMenuItem.Size = new Size(184, 28);
            fontColourToolStripMenuItem.Text = "Font Colour";
            fontColourToolStripMenuItem.Click += fontColourToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, backgroundColourToolStripMenuItem, restoreToDefaultToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(78, 27);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem, customToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(241, 28);
            themeToolStripMenuItem.Text = "Theme";
            themeToolStripMenuItem.Click += themeToolStripMenuItem_Click;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(153, 28);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(153, 28);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new Size(153, 28);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // backgroundColourToolStripMenuItem
            // 
            backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            backgroundColourToolStripMenuItem.Size = new Size(241, 28);
            backgroundColourToolStripMenuItem.Text = "Background Colour";
            backgroundColourToolStripMenuItem.Click += backgroundColourToolStripMenuItem_Click;
            // 
            // restoreToDefaultToolStripMenuItem
            // 
            restoreToDefaultToolStripMenuItem.Name = "restoreToDefaultToolStripMenuItem";
            restoreToDefaultToolStripMenuItem.Size = new Size(241, 28);
            restoreToDefaultToolStripMenuItem.Text = "Restore to Default";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(59, 27);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(141, 28);
            aboutToolStripMenuItem.Text = "About";
            // 
            // textBoxMain
            // 
            textBoxMain.AcceptsTab = true;
            textBoxMain.Font = new Font("Consolas", 11F);
            textBoxMain.Location = new Point(0, 77);
            textBoxMain.Name = "textBoxMain";
            textBoxMain.Size = new Size(1920, 946);
            textBoxMain.TabIndex = 5;
            textBoxMain.Text = "";
            textBoxMain.SelectionChanged += textBoxMain_SelectionChanged;
            textBoxMain.TextChanged += textBoxMain_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 48, 45);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1055);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 25);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblLine, lblChars, lblColumn });
            statusStrip1.Location = new Point(0, 1026);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(203, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblLine
            // 
            lblLine.BackColor = Color.White;
            lblLine.ForeColor = Color.Black;
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(51, 20);
            lblLine.Text = "Line: 1";
            // 
            // lblColumn
            // 
            lblColumn.BackColor = Color.White;
            lblColumn.ForeColor = Color.Black;
            lblColumn.Name = "lblColumn";
            lblColumn.Size = new Size(75, 20);
            lblColumn.Text = "Column: 1";
            // 
            // lblChars
            // 
            lblChars.BackColor = Color.White;
            lblChars.ForeColor = Color.Black;
            lblChars.Name = "lblChars";
            lblChars.Size = new Size(60, 20);
            lblChars.Text = "Chars: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(900, 3);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 0;
            label1.Text = "©️ NotePad by @IDZz";
            // 
            // IDzPad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(textBoxMain);
            Controls.Add(pnlheader);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "IDzPad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += IDzPad_Load;
            pnlheader.ResumeLayout(false);
            pnlheader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlheader;
        private Label lblTitle;
        private Button btnClose;
        private Button btnMinimize;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem fromatToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private RichTextBox textBoxMain;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem fontStyleToolStripMenuItem;
        private ToolStripMenuItem fontColourToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem customToolStripMenuItem;
        private ToolStripMenuItem backgroundColourToolStripMenuItem;
        private ToolStripMenuItem restoreToDefaultToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblLine;
        private ToolStripStatusLabel lblColumn;
        private ToolStripStatusLabel lblChars;
    }
}
