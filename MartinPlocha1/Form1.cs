using System;
using System.IO;
using System.Windows.Forms;


namespace MartinPlocha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ulož(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "txt",
            };
            
            if (sfd.ShowDialog()==DialogResult.OK)
                File.WriteAllText(sfd.FileName, textBox1.Text);
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (RadioButton c in Skupina.Controls)
                if (c.Checked) textBox1.AppendText(c.Text + "\r\n");
        }
    }
}
