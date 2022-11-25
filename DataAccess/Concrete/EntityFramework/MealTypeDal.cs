using Base.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class MealTypeDal : EfEntityRepositoryBase<MealType, DietContext>, IMealTypeDal
    {

    }
}
