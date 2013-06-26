namespace MVP
{
    using System.Collections.Generic;

    public interface IProductView
{
    void Initialize(ProductPresenter presenter);
    string GetFileName();
    void ShowProducts(IEnumerable<Product> products);
    void SetFileName(string fileName);
}
}