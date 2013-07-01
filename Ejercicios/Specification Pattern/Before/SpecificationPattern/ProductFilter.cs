namespace SpecificationPattern
{
    using System.Collections.Generic;

    class ProductFilter
    {
        public IEnumerable<Product> FilterBy(IList<Product> products, ISpecification specification)
        {
            foreach (var product in products)
            {
                if (specification.IsSatisfiedBy(product))
                {
                    yield return product;
                }
            }
        }
    }

    internal class ColorAndSizeSpecification : ISpecification
    {
        private readonly ProductColor productColor;

        private readonly ProductSize productSize;

        public ColorAndSizeSpecification(ProductColor productColor, ProductSize productSize)
        {
            this.productColor = productColor;
            this.productSize = productSize;
        }

        public ProductColor ProductColor
        {
            get
            {
                return this.productColor;
            }
        }

        public ProductSize ProductSize
        {
            get
            {
                return this.productSize;
            }
        }

        public bool IsSatisfiedBy(Product product)
        {
            return (product.Color == ProductColor) && (product.Size == ProductSize);
        }
    }

    internal class SizeSpecification : ISpecification
    {
        private readonly ProductSize productSize;

        public SizeSpecification(ProductSize productSize)
        {
            this.productSize = productSize;
        }

        public ProductSize ProductSize
        {
            get
            {
                return this.productSize;
            }
        }

        public bool IsSatisfiedBy(Product product)
        {
            return product.Size == ProductSize;
        }
    }

    internal interface ISpecification
    {
        bool IsSatisfiedBy(Product product);
    }

    internal class ColorSpecification : ISpecification
    {
        private readonly ProductColor productColor;

        public ColorSpecification(ProductColor productColor)
        {
            this.productColor = productColor;
        }

        public ProductColor ProductColor
        {
            get
            {
                return this.productColor;
            }
        }

        public bool IsSatisfiedBy(Product product)
        {
            return product.Color == ProductColor;
        }
    }
}
