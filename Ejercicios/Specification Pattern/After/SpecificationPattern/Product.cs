namespace SpecificationPattern
{
    class Product
    {
        public Product(Color color)
        {
            this.Color = color;
        }

        public Product(Color color, Size size)
        {
            this.Color = color;
            this.Size = size;
        }

        public Color Color { get; set; }
        public Size Size { get; set; } 
    }
}
