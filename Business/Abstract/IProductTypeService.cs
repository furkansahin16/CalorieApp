using Entities.Concrete;
using Entities.Dtos.ProductTypes;
using Entities.VMs.ProductTypeVMs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IProductTypeService
    {
        void Add(ProductTypeCreateDto productType);
        void Update(ProductTypeUpdateDto productType);
        void Delete(int id);
        List<ProductTypeVm> GetAll();
        List<ProductTypeVm> GetAllByExpression(Expression<Func<ProductType, bool>> expression);
        ProductTypeVm Get(int id);
        ProductTypeVm GetByName(string name);

    }

}
