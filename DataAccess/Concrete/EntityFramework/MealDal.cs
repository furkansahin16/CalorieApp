using Base.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MealDal : EfEntityRepositoryBase<Meal, DietContext>, IMealDal
    {
        public (Meal,DietContext) GetLastMealByUser(string userName)
        {
            DietContext context = new();
            Meal meal = context.Meal.Where(x => x.UserName == userName).OrderByDescending(x => x.CreatedDate).FirstOrDefault();
            return (meal,context);
        }
    }
}
