namespace AperioIndia.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBAccessVM _dbAccessVM;      
        public ProductRepository(DBAccessVM dbAccessVM) 
        {
            _dbAccessVM = dbAccessVM;
        }  
        public async Task<int> ProductCategorySave(ProductCategory model)
        {
            ProductCategory product = new ProductCategory();
            
            int i = 0;
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            product.PName = model.PName;
            product.PImage= model.PImage;
            product.About= model.About; 
            _dbAccessVM.ProductCategory.Add(product);
            i = await _dbAccessVM.SaveChangesAsync();
            if (i > 0)
            {
                i = 1;
                return i;
            }
            else
            {
                return i;
            }
        }

    }
}
