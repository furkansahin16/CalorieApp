using Entities.Concrete;
using Entities.Dtos.Meal;
using Entities.VMs.MealVMs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMealService
    {
        void Add(MealCreateDTO meal);
        void Delete(int id);
        List<MealVm> GetAll();
        List<MealVm> GetAllByExpression(Expression<Func<Meal, bool>> expression);
        MealVm Get(int id);
        MealVm GetLastMealByUserName(string userName);
    }

}
