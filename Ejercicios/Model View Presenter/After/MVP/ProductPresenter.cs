namespace MVP
{
    using System.Windows.Forms;

    public class ProductPresenter
    {
        private readonly IOpenFileDialog openFileDialog;
        private readonly IProductRepository repository;
        private readonly IProductView view;

        public IProductView View
        {
            get { return this.view; }
        }

        public ProductPresenter() : this(new Form1(), new ProductRepository(), new OpenFileDialogWrapper())
        {
        }

        public ProductPresenter(IProductView view, IProductRepository repository, IOpenFileDialog openFileDialog)
        {
            this.view = view;
            view.Initialize(this);
            this.repository = repository;
            this.openFileDialog = openFileDialog;
        }

        public void GetProducts()
        {
            var products = this.repository.GetByFileName(this.view.GetFileName());
            this.view.ShowProducts(products);
        }

        public void BrowseForFileName()
        {
            var result = this.openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                this.view.SetFileName(this.openFileDialog.FileName);
        }
    }
}