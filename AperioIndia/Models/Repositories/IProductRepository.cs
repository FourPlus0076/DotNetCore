namespace AperioIndia.Models.Repositories
{
    public interface IProductRepository
    {
       Task<int> ProductCategorySave(ProductCategory model);
    }
}
