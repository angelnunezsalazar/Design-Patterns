namespace SpecificationPattern.Test
{
    using System.Collections.Generic;
    using System.Linq;

    using NUnit.Framework;

    [TestFixture]
    class ProductFilterTest
    {
        [Test]
        public void FilterByBlueReturn2()
        {
            ProductFilter filter = new ProductFilter();
            IList<Product> products = this.BuildProducts();

            var result = filter.ByColor(products, ProductColor.Blue);

            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Has.All.Matches<Product>(x => x.Color == ProductColor.Blue));
        }

        [Test]
        public void FilterBySmallReturn2()
        {
            ProductFilter filter = new ProductFilter();
            IList<Product> products = this.BuildProducts();

            var result = filter.BySize(products,  ProductSize.Small);

            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Has.All.Matches<Product>(x => x.Size == ProductSize.Small));
        }

        [Test]
        public void FilterByBlueAndSmallReturn1()
        {
            ProductFilter filter = new ProductFilter();
            IList<Product> products = this.BuildProducts();

            var result = filter.ByColorAndSize(products, ProductColor.Blue, ProductSize.Small);

            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Has.All.Matches<Product>(x => x.Size == ProductSize.Small));
        }

        private IList<Product> BuildProducts()
        {
            return new List<Product> { 
                new Product(ProductColor.Blue, ProductSize.Small), 
                new Product(ProductColor.Yellow, ProductSize.Small), 
                new Product(ProductColor.Yellow, ProductSize.Medium), 
                new Product(ProductColor.Red, ProductSize.Large), 
                new Product(ProductColor.Blue, ProductSize.ReallyBig)
            };
        }
    }
}
