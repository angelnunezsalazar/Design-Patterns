namespace SpecificationPattern
{
    class SpecificationColorAndSize : ISpecification
    {
        private readonly Color productColor;
        private readonly Size productSize;

        public SpecificationColorAndSize(Color productColor, Size productSize)
        {
            this.productColor = productColor;
            this.productSize = productSize;
        }

        public bool IsSatisfiedBy(Product product)
        {
            return product.Color == this.productColor && product.Size == this.productSize;
        }
    }
}
