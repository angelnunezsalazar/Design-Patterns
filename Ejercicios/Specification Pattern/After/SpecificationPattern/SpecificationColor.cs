namespace SpecificationPattern
{
    class SpecificationColor : ISpecification
    {
        private readonly Color productColor;

        public SpecificationColor(Color productColor)
        {
            this.productColor = productColor;
        }

        public bool IsSatisfiedBy(Product product)
        {
            return product.Color == this.productColor;
        }
    }
}