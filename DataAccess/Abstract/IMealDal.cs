using Base.DataAccess;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMealDal : IEntityRepository<Meal,DietContext>
    {
        (Meal,DietContext) GetLastMealByUser(string userName);
    }
}
