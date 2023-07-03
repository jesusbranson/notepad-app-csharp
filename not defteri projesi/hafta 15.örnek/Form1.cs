namespace hafta_15.örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = "yeni belge - not defteri";
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = openFileDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.OverwritePrompt = true; // varlon dosya değişsinmi içeriği diye uyarı çıkarıyo uyarı kuusu 

            sonuc = saveFileDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;

            sonuc = fontDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }


        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;

            sonuc = colorDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}