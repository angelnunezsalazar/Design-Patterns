namespace MVP
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Xml;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                this.txtFileName.Text = this.openFileDialog1.FileName;
                this.btnLoad.Enabled = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            var fileName = this.txtFileName.Text;
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var reader = XmlReader.Create(fs);
                while (reader.Read())
                {
                    if (reader.Name != "product") continue;
                    var id = reader.GetAttribute("id");
                    var name = reader.GetAttribute("name");
                    var unitPrice = reader.GetAttribute("unitPrice");
                    var discontinued = reader.GetAttribute("discontinued");
                    var item = new ListViewItem(new string[] { id, name, unitPrice, discontinued });
                    this.listView1.Items.Add(item);
                }
            }

        }

    }
}
