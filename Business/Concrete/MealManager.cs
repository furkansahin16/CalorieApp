using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Meal;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.MealVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MealManager : IMealService
    {
        private readonly IMealDal _mealDal;
        private readonly IMealTypeService _mealTypeService;
        private readonly IMealDetailService _mealDetailService;
        public MealManager(IMealTypeService mealTypeService, IMealDal mealDal, IMealDetailService mealDetailService)
        {
            _mealTypeService = mealTypeService;
            _mealDal = mealDal;
            _mealDetailService = mealDetailService;
        }
        [ValidationAspect(typeof(MealCreateValidator))]
        public void Add(MealCreateDTO meal)
        {
            Meal newMeal = new Meal()
            {
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = meal.UserName,
                MealTypeID = _mealTypeService.GetByName(meal.MealTypeName).Id,
            };

            _mealDal.Add(newMeal);

        }

        public void Delete(int id)
        {
            var getMealTuple = _mealDal.Get(m => m.Id == id);
            Meal meal = getMealTuple.Item1;
            if (meal == null) throw new IdNotFoundException("Girilen idye ait öğün bulunamadı.");
            foreach (var mealDetail in meal.MealDetails)
            {
                _mealDetailService.Delete(mealDetail.Id);
            }
            _mealDal.Delete(meal);
            getMealTuple.Item2.Dispose();
        }

        public MealVm Get(int id)
        {
            var getMealTuple = _mealDal.Get(m => m.Id == id);
            Meal meal = getMealTuple.Item1;
            if (meal == null) throw new IdNotFoundException("Girilen idye ait öğün bulunamadı.");

            MealVm mealVm = new MealVm()
            {
                Id = id,
                Date=meal.CreatedDate,
                MealType= meal.MealType.TypeName,
            };

            foreach (var item in meal.MealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Id = item.Id,
                    Gram = item.Gram,
                    UnitCalorie = item.Product.UnitCalorie,
                    ProductType = item.Product.ProductType.ProductTypeName,
                    Product = item.Product.ProductName,
                    Image = item.Product.Image
                };
                mealVm.MealDetailVm.Add(mealDetailVm);
            }

            getMealTuple.Item2.Dispose();
            return mealVm;
        }

        public List<MealVm> GetAll()
        {
            var getAllMealTuple = _mealDal.GetAll();
            List<Meal> meals = getAllMealTuple.Item1;
            List<MealVm> mealVms = new List<MealVm>();
            foreach (var meal in meals)
            {
                MealVm mealVm = new MealVm()
                {
                    Date = meal.CreatedDate,
                    MealType = meal.MealType.TypeName,
                    Id = meal.Id,
                };

                foreach (var item in meal.MealDetails)
                {
                    MealDetailVm mealDetailVm = new MealDetailVm()
                    {
                        Id = item.Id,
                        Gram = item.Gram,
                        UnitCalorie = item.Product.UnitCalorie,
                        ProductType = item.Product.ProductType.ProductTypeName,
                        Product = item.Product.ProductName,
                        Image = item.Product.Image
                        
                    };
                    mealVm.MealDetailVm.Add(mealDetailVm);
                }

                mealVms.Add(mealVm);
            }
            getAllMealTuple.Item2.Dispose();
            return mealVms;
        }

        public List<MealVm> GetAllByExpression(Expression<Func<Meal, bool>> expression)
        {
            var getAllMealByExpressionTuple = _mealDal.GetAll(expression);
            List<Meal> meals = getAllMealByExpressionTuple.Item1;
            List<MealVm> mealVms = new List<MealVm>();
            if (meals == null) throw new Exception();

            foreach (var meal in meals)
            {
                MealVm mealVm = new MealVm()
                {
                    Date = meal.CreatedDate,
                    MealType = meal.MealType.TypeName,
                    Id=meal.Id
                };

                foreach (var item in meal.MealDetails)
                {
                    MealDetailVm mealDetailVm = new MealDetailVm()
                    {
                        Id = item.Id,
                        Gram = item.Gram,
                        UnitCalorie = item.Product.UnitCalorie,
                        ProductType = item.Product.ProductType.ProductTypeName,
                        Product = item.Product.ProductName,
                        Image = item.Product.Image

                    };
                    mealVm.MealDetailVm.Add(mealDetailVm);
                }

                mealVms.Add(mealVm);
            }
            getAllMealByExpressionTuple.Item2.Dispose();
            return mealVms;
        }

        public MealVm GetLastMealByUserName(string userName)
        {
            var getLasTMealTuple = _mealDal.GetLastMealByUser(userName);
            Meal meal = getLasTMealTuple.Item1;
            if (meal == null) throw new Exception("Kullanıcının daha önce kayıtlı öğünü yok.");

            MealVm mealVm = new MealVm()
            {
                MealType = meal.MealType.TypeName,
                Date = meal.CreatedDate,
                Id=meal.Id
            };

            foreach (var item in meal.MealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    UnitCalorie = item.Product.UnitCalorie,
                    ProductType = item.Product.ProductType.ProductTypeName,
                    Product = item.Product.ProductName
                };
                mealVm.MealDetailVm.Add(mealDetailVm);
            }
            getLasTMealTuple.Item2.Dispose();
            return mealVm;
        }

       
    }

}
