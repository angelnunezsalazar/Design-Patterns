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
            // arrange
            ProductFilter filter = new ProductFilter();
            IList<Product> products = this.BuildProducts();

            // act
            var result = filter.By(products, new SpecificationColor(Color.Blue));

            // assert
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Has.All.Matches<Product>(x => x.Color == Color.Blue));
        }

        [Test]
        public void FilterBySmallReturn2()
        {
            // arrange
            ProductFilter filter = new ProductFilter();
            IList<Product> products = this.BuildProducts();

            // act
            var result = filter.By(products,  new SpecificationSize(Size.Small));

            // assert
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Has.All.Matches<Product>(x => x.Size == Size.Small));
        }

        [Test]
        public void FilterByBlueAndSmallReturn1()
        {
            // arrange
            ProductFilter filter = new ProductFilter();
            IList<Product> products = this.BuildProducts();

            // act
            var result = filter.By(products, new SpecificationColorAndSize(Color.Blue, Size.Small));

            // assert
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Has.All.Matches<Product>(x => x.Size == Size.Small));
        }

        private IList<Product> BuildProducts()
        {
            return new List<Product> { 
                new Product(Color.Blue, Size.Small), 
                new Product(Color.Yellow, Size.Small), 
                new Product(Color.Yellow, Size.Medium), 
                new Product(Color.Red, Size.Large), 
                new Product(Color.Blue, Size.ReallyBig)
            };
        }
    }
}
