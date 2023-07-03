namespace hafta_15.örnek
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            biçimVeDüzenToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kesToolStripMenuItem1 = new ToolStripMenuItem();
            kopyalaToolStripMenuItem1 = new ToolStripMenuItem();
            yapıştırToolStripMenuItem1 = new ToolStripMenuItem();
            ileriToolStripMenuItem = new ToolStripMenuItem();
            geriToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, biçimVeDüzenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(517, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, açToolStripMenuItem, kaydetToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(50, 20);
            dosyaToolStripMenuItem.Text = "dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(149, 22);
            yeniToolStripMenuItem.Text = "yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Image = (Image)resources.GetObject("açToolStripMenuItem.Image");
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(149, 22);
            açToolStripMenuItem.Text = "aç";
            açToolStripMenuItem.Click += açToolStripMenuItem_Click;
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Image = (Image)resources.GetObject("kaydetToolStripMenuItem.Image");
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            kaydetToolStripMenuItem.Size = new Size(149, 22);
            kaydetToolStripMenuItem.Text = "kaydet";
            kaydetToolStripMenuItem.Click += kaydetToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(149, 22);
            çıkışToolStripMenuItem.Text = "çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // biçimVeDüzenToolStripMenuItem
            // 
            biçimVeDüzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıTipiToolStripMenuItem, renkToolStripMenuItem, toolStripSeparator1, kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            biçimVeDüzenToolStripMenuItem.Name = "biçimVeDüzenToolStripMenuItem";
            biçimVeDüzenToolStripMenuItem.Size = new Size(99, 20);
            biçimVeDüzenToolStripMenuItem.Text = "biçim ve düzen";
            // 
            // yazıTipiToolStripMenuItem
            // 
            yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            yazıTipiToolStripMenuItem.Size = new Size(115, 22);
            yazıTipiToolStripMenuItem.Text = "yazı tipi";
            yazıTipiToolStripMenuItem.Click += yazıTipiToolStripMenuItem_Click;
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(115, 22);
            renkToolStripMenuItem.Text = "renk";
            renkToolStripMenuItem.Click += renkToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(112, 6);
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(115, 22);
            kesToolStripMenuItem.Text = "kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(115, 22);
            kopyalaToolStripMenuItem.Text = "kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(115, 22);
            yapıştırToolStripMenuItem.Text = "yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 198);
            panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(517, 198);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { kesToolStripMenuItem1, kopyalaToolStripMenuItem1, yapıştırToolStripMenuItem1, ileriToolStripMenuItem, geriToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(116, 114);
            // 
            // kesToolStripMenuItem1
            // 
            kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            kesToolStripMenuItem1.Size = new Size(115, 22);
            kesToolStripMenuItem1.Text = "kes";
            kesToolStripMenuItem1.Click += kesToolStripMenuItem1_Click;
            // 
            // kopyalaToolStripMenuItem1
            // 
            kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            kopyalaToolStripMenuItem1.Size = new Size(115, 22);
            kopyalaToolStripMenuItem1.Text = "kopyala";
            // 
            // yapıştırToolStripMenuItem1
            // 
            yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            yapıştırToolStripMenuItem1.Size = new Size(115, 22);
            yapıştırToolStripMenuItem1.Text = "yapıştır";
            // 
            // ileriToolStripMenuItem
            // 
            ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            ileriToolStripMenuItem.Size = new Size(115, 22);
            ileriToolStripMenuItem.Text = "ileri ";
            // 
            // geriToolStripMenuItem
            // 
            geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            geriToolStripMenuItem.Size = new Size(115, 22);
            geriToolStripMenuItem.Text = "geri al";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(517, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 222);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Not Defteri";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem biçimVeDüzenToolStripMenuItem;
        private ToolStripMenuItem yazıTipiToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kesToolStripMenuItem1;
        private ToolStripMenuItem kopyalaToolStripMenuItem1;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripMenuItem ileriToolStripMenuItem;
        private ToolStripMenuItem geriToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}