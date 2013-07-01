namespace MVP.Tests
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProductsPresenterTests
    {
        [TestMethod]
        public void ShowDialodShouldSetFileNameInView()
        {
            var stubView = new StubView();
            var productsPresenter = new ProductsPresenter(stubView, null, new StubOpenDialog());
            productsPresenter.OpenFileDialog();
            Assert.AreEqual(stubView.FileName, "MyFileName.txt");
        }

        public class StubView:IProductsView
        {
            public string FileName;
            public void SetFileName(string fileName)
            {
                FileName = fileName;
            }

            public void ShowProducs(List<Product> products)
            {
            }
        }

        public class StubOpenDialog : IOpenFileWrapper
        {
            public string FileName
            {
                get
                {
                    return "MyFileName.txt";
                }
            }

            public DialogResult ShowDialog()
            {
                return DialogResult.OK;
            }
        }
    }
}