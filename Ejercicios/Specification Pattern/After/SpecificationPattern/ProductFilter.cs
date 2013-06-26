namespace SpecificationPattern
{
    using System.Collections.Generic;

    class ProductFilter
    {
        public IEnumerable<Product> By(IList<Product> products, ISpecification specification)
        {
            foreach (var product in products)
            {
                if (specification.IsSatisfiedBy(product))
                    yield return product;
            }
        }
    }

}
