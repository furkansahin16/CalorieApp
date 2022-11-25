using Base.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProductDal : EfEntityRepositoryBase<Product, DietContext>, IProductDal
    {

    }
}
