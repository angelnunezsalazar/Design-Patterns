namespace MVP
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class Form1 : Form, IProductView
    {
        private ProductPresenter presenter;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.presenter.BrowseForFileName();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.presenter.GetProducts();
        }

        public void Initialize(ProductPresenter presenter)
        {
            this.presenter = presenter;
        }

        public string GetFileName()
        {
            return this.txtFileName.Text;
        }

        public void SetFileName(string fileName)
        {
            this.txtFileName.Text = fileName;
            this.btnLoad.Enabled = true;
        }

        public void ShowProducts(IEnumerable<Product> products)
        {
            this.listView1.Items.Clear();
            foreach (var product in products)
            {
                    var item = new ListViewItem(new[]
                                                    {
                                                        product.Id.ToString(),
                                                        product.Name,
                                                        product.UnitPrice.ToString(),
                                                        product.Discontinued.ToString()
                                                    });
                    this.listView1.Items.Add(item);
            }
        }
    }
}
