using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos.MealType;
using Entities.Enums;
using Entities.VMs.MealTypeVMs;
using Entities.VMs.ProductTypeVMs;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MealTypeManager : IMealTypeService
    {
        private readonly IMealTypeDal _mealTypeDal;
        public MealTypeManager(IMealTypeDal mealTypeDal)
        {
            _mealTypeDal = mealTypeDal;
        }

        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeCreateValidator))]
        public void Add(MealTypeCreateDto mealType)
        {
            var getMealTypeTuple = _mealTypeDal.Get(pt => pt.TypeName == mealType.MealTypeName);
            if (getMealTypeTuple.Item1 != null)
            {
                throw new AlreadyExistsException("Eklenmeye çalışılan öğün tipi zaten mevcut");
            };
            MealType newMealType = new MealType()
            {
                TypeName = mealType.MealTypeName
            };

            getMealTypeTuple.Item2.Dispose();
            _mealTypeDal.Add(newMealType);
        }

        [SecuredOperation(UserClaims.Admin)]
        public void Delete(int id)
        {
            var getMealTypeTuple = _mealTypeDal.Get(pt => pt.Id == id);
            MealType mealType = getMealTypeTuple.Item1;
            if (mealType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir öğün tipi bulunamadı");
            }
            getMealTypeTuple.Item2.Dispose();
            _mealTypeDal.Delete(mealType);
        }

        public List<MealTypeVm> GetAll()
        {
            var mealTypeGetAllTuple = _mealTypeDal.GetAll();
            List<MealType> mealTypes = mealTypeGetAllTuple.Item1;
            List<MealTypeVm> MealTypeVmList = new List<MealTypeVm>();

            foreach (MealType item in mealTypes)
            {
                MealTypeVm productTypeVm = new MealTypeVm()
                {
                    MealTypeName = item.TypeName,
                    Id= item.Id
                };
                MealTypeVmList.Add(productTypeVm);
            }
            mealTypeGetAllTuple.Item2.Dispose();
            return MealTypeVmList;
        }

        public List<MealTypeVm> GetAllByExpression(Expression<Func<MealType, bool>> expression)
        {
            var mealTypeGetAllTuple = _mealTypeDal.GetAll(expression);
            List<MealType> mealTypes = mealTypeGetAllTuple.Item1;
            List<MealTypeVm> MealTypeVmList = new List<MealTypeVm>();

            foreach (MealType item in mealTypes)
            {
                MealTypeVm productTypeVm = new MealTypeVm()
                {
                    MealTypeName = item.TypeName
                };
                MealTypeVmList.Add(productTypeVm);
            }
            mealTypeGetAllTuple.Item2.Dispose();
            return MealTypeVmList;
        }

        public MealTypeVm GetById(int id)
        {
            var getMealTypeTuple = _mealTypeDal.Get(pt => pt.Id == id);
            MealType mealType = getMealTypeTuple.Item1;
            if (mealType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir öğün tipi bulunamadı");
            }

            MealTypeVm mealTypeVm = new MealTypeVm()
            {
                 MealTypeName= mealType.TypeName
            };
            getMealTypeTuple.Item2.Dispose();
            return mealTypeVm;
        }

        public MealTypeVm GetByName(string TypeName)
        {
            var getMealTypeTuple =_mealTypeDal.Get(pt => pt.TypeName == TypeName);
            MealType mealType = getMealTypeTuple.Item1;
            if (mealType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir öğün tipi bulunamadı");
            }

            MealTypeVm mealTypeVm = new MealTypeVm()
            {
                Id = mealType.Id,
                MealTypeName = mealType.TypeName
            };
            getMealTypeTuple.Item2.Dispose();
            return mealTypeVm;
        }

        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeUpdateValidator))]
        public void Update(MealTypeUpdateDto mealType)
        {
            MealType mealTypeUpdated = new MealType()
            {
                Id = mealType.Id,
                TypeName = mealType.MealTypeName
            };

            _mealTypeDal.Update(mealTypeUpdated);
        }
    }

}
