using ProductManagement.Categories;
using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ProductManagement.Data
{
    public class ProductManagementDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category,Guid> _categoryRepository;
        private readonly IRepository<Product,Guid> _productRepository;

        public ProductManagementDataSeedContributor(
        IRepository<Category, Guid> categoryRepository,
        IRepository<Product, Guid> productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            /***** TODO: Seed initial data here *****/
        }
    }
}
