namespace MVP
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.IO;
    using System.Xml;

    public interface IProductsView
    {
        void SetFileName(string fileName);

        void ShowProducs(List<Product> products);
    }

    public partial class Form1 : Form, IProductsView
    {
        public Form1()
        {
            this.presenter=new ProductsPresenter(this, new ProductDAO(), new OpenFileWrapper());
            this.InitializeComponent();
        }

        private ProductsPresenter presenter;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.presenter.OpenFileDialog();
        }

        public void SetFileName(string fileName)
        {
            this.txtFileName.Text = fileName;
            this.btnLoad.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var fileName = this.txtFileName.Text;
            this.presenter.GetProducts(fileName);
        }

        public void ShowProducs(List<Product> products)
        {
            this.listView1.Items.Clear();
            foreach (var product in products)
            {
                var item = new ListViewItem(new string[] { product.Id, product.Name, product.UnitPrice, product.Discontinued });
                this.listView1.Items.Add(item);
            }
        }
    }

    internal interface IOpenFileWrapper
    {
        string FileName { get; }

        DialogResult ShowDialog();
    }

    internal class OpenFileWrapper : IOpenFileWrapper
    {
        private OpenFileDialog openFileDialog=new OpenFileDialog();

        public string FileName
        {
            get
            {
                return openFileDialog.FileName;
            }
        }

        public DialogResult ShowDialog()
        {
            return openFileDialog.ShowDialog();
        }
    }

    internal class ProductsPresenter
    {
        private readonly IProductsView view;

        private IProductDAO productDao;

        private IOpenFileWrapper openFileWrapper;

        public ProductsPresenter(IProductsView view, IProductDAO productDAO, IOpenFileWrapper openFileWrapper)
        {
            this.view = view;
            this.productDao = productDAO;
            this.openFileWrapper = openFileWrapper;
        }

        public void GetProducts(string fileName)
        {
            var products = this.productDao.ReadProducts(fileName);
            view.ShowProducs(products);
        }

        public void OpenFileDialog()
        {
            var result = this.openFileWrapper.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = this.openFileWrapper.FileName;
                view.SetFileName(fileName);
            }
        }
    }

    internal interface IProductDAO
    {
        List<Product> ReadProducts(string fileName);
    }

    internal class ProductDAO : IProductDAO
    {
        public List<Product> ReadProducts(string fileName)
        {
            var products = new List<Product>();
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var reader = XmlReader.Create(fs);
                while (reader.Read())
                {
                    if (reader.Name != "product")
                    {
                        continue;
                    }
                    var product = new Product(
                        reader.GetAttribute("id"),
                        reader.GetAttribute("name"),
                        reader.GetAttribute("unitPrice"),
                        reader.GetAttribute("discontinued"));
                    products.Add(product);
                }
            }
            return products;
        }
    }

    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string UnitPrice { get; set; }

        public string Discontinued { get; set; }

        public Product(string id, string name, string unitPrice, string discontinued)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            Discontinued = discontinued;
        }
    }
}
