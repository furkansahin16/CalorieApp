using Base.DataAccess;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMealTypeDal : IEntityRepository<MealType, DietContext>
    {
    }
}
