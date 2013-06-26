namespace MVP.Test
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Moq;

    using NUnit.Framework;

    public class ProductPresenterTest
    {
        protected ProductPresenter presenter;
        protected Mock<IProductView> view;
        protected Mock<IProductRepository> repository;
        protected Mock<IOpenFileDialog> dialog;

        [SetUp]
        public void Setup()
        {
            this.SetupContext();
        }

        protected virtual void SetupContext()
        {
            // Arrange
            this.repository = new Mock<IProductRepository>();
            this.view = new Mock<IProductView>();
            this.dialog = new Mock<IOpenFileDialog>();
            this.presenter = new ProductPresenter(this.view.Object, this.repository.Object, this.dialog.Object);
        }
    }

    [TestFixture]
    public class when_instantiating_product_presenter : ProductPresenterTest
    {
        [Test]
        public void should_initialize_view()
        {
            this.view.Verify(x => x.Initialize(this.presenter));
        }
    }

    [TestFixture]
    public class when_browsing_for_filename : ProductPresenterTest
    {
        private string fileName;

        protected override void SetupContext()
        {
            base.SetupContext();
            // Arrange
            this.fileName = "Products.xml";
            this.dialog.Setup(x => x.ShowDialog()).Returns(DialogResult.OK);
            this.dialog.Setup(x => x.FileName).Returns(this.fileName);

            // Act
            this.presenter.BrowseForFileName();
        }

        [Test]
        public void should_call_open_file_dialog()
        {
            this.dialog.Verify(x => x.ShowDialog());
        }

        [Test]
        public void should_set_file_name_on_view()
        {
            this.view.Verify(x => x.SetFileName(this.fileName));
        }
    }

    [TestFixture]
    public class when_browsing_for_filename_and_user_aborts : ProductPresenterTest
    {
        private string fileName;

        protected override void SetupContext()
        {
            base.SetupContext();
            // Arrange
            this.fileName = "Products.xml";
            this.dialog.Setup(x => x.ShowDialog()).Returns(DialogResult.Cancel);
            this.dialog.Setup(x => x.FileName).Returns(this.fileName);

            // Act
            this.presenter.BrowseForFileName();
        }

        [Test]
        [ExpectedException(typeof(MockException))]
        public void should_not_set_file_name_on_view()
        {
            this.view.Verify(x => x.SetFileName(this.fileName));
        }
    }

    public class when_getting_products_from_product_presenter : ProductPresenterTest
    {
        private string fileName;
        private IEnumerable<Product> products;

        protected override void SetupContext()
        {
            base.SetupContext();
            // Arrange
            this.fileName = "Products.xml";
            this.products = new List<Product>();

            this.view.Setup(x => x.GetFileName()).Returns(this.fileName);
            this.repository.Setup(x => x.GetByFileName(this.fileName)).Returns(this.products);

            // Act
            this.presenter.GetProducts();
        }

        [Test]
        public void should_get_file_name_form_view()
        {
            this.view.Verify(x => x.GetFileName());
        }

        [Test]
        public void should_get_products_from_repository()
        {

            this.repository.Verify(x => x.GetByFileName(this.fileName));
        }

        [Test]
        public void should_pass_products_to_view_for_display()
        {
            this.view.Verify(x => x.ShowProducts(this.products));
        }
    }
}