using Entities.Concrete;
using Entities.Dtos.Product;
using Entities.VMs.ProductVMs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(ProductCreateDTO product);
        void Update(ProductUpdateDTO product);
        void Delete(int id);
        List<ProductVm> GetAll();
        List<ProductVm> GetAllByExpression(Expression<Func<Product, bool>> expression);
        ProductVm GetById(int id);
        ProductVm GetByName(string name);
    }

}
