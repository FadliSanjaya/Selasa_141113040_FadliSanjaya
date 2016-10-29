namespace Latihan_4_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bold = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.size = new System.Windows.Forms.ComboBox();
            this.Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Calibri = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(445, 333);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // bold
            // 
            this.bold.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.Location = new System.Drawing.Point(44, 2);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(44, 21);
            this.bold.TabIndex = 2;
            this.bold.UseVisualStyleBackColor = false;
            this.bold.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(94, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 21);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(145, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 20);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files|*.txt|RTF Files|*.rtf";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Location = new System.Drawing.Point(330, 2);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(69, 21);
            this.size.TabIndex = 7;
            this.size.Text = "Size";
            this.size.SelectedIndexChanged += new System.EventHandler(this.size_SelectedIndexChanged);
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Color.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color.Location = new System.Drawing.Point(193, 0);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(63, 22);
            this.Color.TabIndex = 1;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = false;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Calibri
            // 
            this.Calibri.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Calibri.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibri.FormattingEnabled = true;
            this.Calibri.Location = new System.Drawing.Point(262, 1);
            this.Calibri.Name = "Calibri";
            this.Calibri.Size = new System.Drawing.Size(62, 21);
            this.Calibri.TabIndex = 9;
            this.Calibri.Text = "Calibri";
            this.Calibri.SelectedIndexChanged += new System.EventHandler(this.Calibri_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 357);
            this.Controls.Add(this.Calibri);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.size);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Latihan_4_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox Calibri;
    }
    }


