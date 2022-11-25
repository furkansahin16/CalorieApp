using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.MealDetails;
using Entities.VMs;
using Entities.VMs.MealDetailVMs;
using Entities.VMs.ProductVMs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MealDetailManager : IMealDetailService
    {
        IMealDetailDal _mealDetailDal;
        IMealTypeService _mealTypeService;
        IProductService _productService;
        public MealDetailManager(IMealDetailDal mealDetailDal, IMealTypeService mealTypeService, IProductService productService)
        {
            _mealDetailDal = mealDetailDal;
            _mealTypeService = mealTypeService;
            _productService = productService;
        }

        [ValidationAspect(typeof(MealDetailCreateValidator))]
        public void Add(MealDetailCreateDto mealDetail)
        {

            MealDetail newMealDetail = new MealDetail()
            {
                Gram = mealDetail.Gram,
                MealID = mealDetail.MealID,
                ProductId = mealDetail.ProductId,
            };

            _mealDetailDal.Add(newMealDetail);
        }

        public void Delete(int id)
        {
            MealDetail deleteMealDetail = (_mealDetailDal.Get(m => m.Id == id)).Item1;

            if (deleteMealDetail == null)
            {
                throw new IdNotFoundException("Gönderilen id ye ait meal detail bulunamadı.");
            }
            _mealDetailDal.Delete(deleteMealDetail);
        }

        public void DeleteRange(List<int> ids)
        {
            foreach (var item in ids)
            {
                MealDetail deleteMealDetail = _mealDetailDal.Get(m => m.Id == item).Item1;
                _mealDetailDal.Delete(deleteMealDetail);
            }
        }

        public List<MealDetailVm> GetAll()
        {
            var getAllTuple = _mealDetailDal.GetAll();
            List<MealDetail> mealDetails = getAllTuple.Item1;
            List<MealDetailVm> mealDetailVms = new List<MealDetailVm>();
            foreach (var item in mealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.TypeName,
                    Id = item.Id,
                    Product = item.Product.ProductName,
                    UnitCalorie = item.Product.UnitCalorie,
                    Image = item.Product.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }
            getAllTuple.Item2.Dispose();
            return mealDetailVms;
        }

        public List<MealDetailVm> GetAllByExpression(Expression<Func<MealDetail, bool>> expression)
        {
            var getAllByExpressionTuple = _mealDetailDal.GetAll(expression);
            List<MealDetail> mealDetails = getAllByExpressionTuple.Item1;
            List<MealDetailVm> mealDetailVms = new List<MealDetailVm>();
            foreach (var item in mealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.TypeName,
                    Id = item.Id,
                    Product = item.Product.ProductName,
                    UnitCalorie = item.Product.UnitCalorie,
                    Image = item.Product.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }
            getAllByExpressionTuple.Item2.Dispose();
            return mealDetailVms;
        }

        public MealDetailVm GetById(int id)
        {
            var getByIdTuple = _mealDetailDal.Get(md => md.Id == id);
            MealDetail mealDetail = getByIdTuple.Item1;
            if (mealDetail == null)
            {
                throw new IdNotFoundException("Gönderilen idye ait öğün detayı bulunamadı.");
            }

            MealDetailVm mealDetailVm = new MealDetailVm()
            {
                Id = mealDetail.Id,
                Gram = mealDetail.Gram,
                MealType = mealDetail.Meal.MealType.TypeName,
                Product = mealDetail.Product.ProductName,
                UnitCalorie = mealDetail.Product.UnitCalorie,
                Image = mealDetail.Product.Image,
                ProductType = mealDetail.Product.ProductType.ProductTypeName
            };
            getByIdTuple.Item2.Dispose();
            return mealDetailVm;
        }

        public List<MealDetailVm> GetByProductName(string productName)
        {
            var getByProductNameTuple = _mealDetailDal.GetAll(md => md.Product.ProductName == productName);
            List<MealDetail> mealDetails = getByProductNameTuple.Item1;
            List<MealDetailVm> mealDetailVms = new List<MealDetailVm>();
            foreach (var item in mealDetails)
            {
                MealDetailVm mealDetailVm = new MealDetailVm()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.TypeName,
                    Id = item.Id,
                    Product = item.Product.ProductName,
                    UnitCalorie = item.Product.UnitCalorie,
                    Image = item.Product.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }
            getByProductNameTuple.Item2.Dispose();
            return mealDetailVms;
        }
        [ValidationAspect(typeof(MealDetailUpdateValidator))]
        public void Update(MealDetailUpdateDto mealDetail)
        {
            MealDetail updatedMealDetail = _mealDetailDal.Get(md => md.Id == mealDetail.Id).Item1;
            if (mealDetail.Gram != null && mealDetail.Gram != updatedMealDetail.Gram) updatedMealDetail.Gram = mealDetail.Gram;
            if (updatedMealDetail.Product.ProductName != mealDetail.ProductName)
            {
                ProductVm product = _productService.GetByName(mealDetail.ProductName);
                updatedMealDetail.ProductId = product.Id;
            }

            _mealDetailDal.Update(updatedMealDetail);
        }

        public List<ReportVm> GetTopTenProduct(Expression<Func<MealDetail, bool>> expression = null)
        {
            var getTopTenTuple = _mealDetailDal.GetAll(expression);
            return (_mealDetailDal.GetAll(expression).Item1).GroupBy(x => x.Product.ProductName).Select(md => new ReportVm { Key = md.Key, Toplam = md.Count() }).OrderByDescending(x=>x.Toplam).ToList(); ;
            
        }


    }


}
