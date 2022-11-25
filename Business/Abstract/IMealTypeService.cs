using Entities.Concrete;
using Entities.Dtos.MealType;
using Entities.VMs.MealTypeVMs;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IMealTypeService
    {
        void Add(MealTypeCreateDto mealType);
        void Update(MealTypeUpdateDto mealType);
        void Delete(int id);
        List<MealTypeVm> GetAll();
        List<MealTypeVm> GetAllByExpression(Expression<Func<MealType, bool>> expression);
        MealTypeVm GetById(int id);
        MealTypeVm GetByName(string TypeName);
    }

}
