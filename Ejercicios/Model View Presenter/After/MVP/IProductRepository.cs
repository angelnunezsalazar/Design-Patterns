namespace MVP
{
    using System.Collections.Generic;

    public interface IProductRepository
    {
        IEnumerable<Product> GetByFileName(string fileName);
    }
}