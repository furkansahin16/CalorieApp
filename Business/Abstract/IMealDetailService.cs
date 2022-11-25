using Business.Concrete;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Entities.Concrete;
using Entities.Dtos.MealDetails;
using Entities.VMs;
using Entities.VMs.MealDetailVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMealDetailService
    {
        void Add(MealDetailCreateDto mealDetail);
        void Update(MealDetailUpdateDto mealDetail);
        void Delete(int id);
        void DeleteRange(List<int> ids);
        List<MealDetailVm> GetAll();
        List<MealDetailVm> GetAllByExpression(Expression<Func<MealDetail,bool>> expression );
        List<MealDetailVm> GetByProductName(string productName);
        MealDetailVm GetById(int id);
        List<ReportVm> GetTopTenProduct(Expression<Func<MealDetail, bool>> expression = null);

    }
}
