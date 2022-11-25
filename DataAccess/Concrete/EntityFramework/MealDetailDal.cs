using Base.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MealDetailDal : EfEntityRepositoryBase<MealDetail, DietContext>, IMealDetailDal
    {
        public List<ReportVm> GetTopTenProduct(Expression<Func<MealDetail, bool>> expression = null)
        {
            DietContext context = new();
            var result = (context.Set<MealDetail>().GroupBy(x => x.Product.ProductName).Select(md => new ReportVm { Key = md.Key, Toplam = md.Count() })).ToList();
            return result;
            //Buraya tekrar bak
        }
    }
}
