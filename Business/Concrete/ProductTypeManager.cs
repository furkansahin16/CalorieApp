using Base.Aspects.Autofac.Validation;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.ProductTypes;
using Entities.Enums;
using Entities.VMs.ProductTypeVMs;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductTypeManager : IProductTypeService
    {
        private readonly IProductTypeDal _productTypeDal;
        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }
        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeCreateValidator))]
        public void Add(ProductTypeCreateDto productType)
        {
            var getProductTypeTuple = _productTypeDal.Get(pt => pt.ProductTypeName==productType.ProductTypeName);
            if (getProductTypeTuple.Item1 != null) throw new AlreadyExistsException("Eklenmeye çalışılan öğün tipi zaten mevcut");
            ProductType newProductType = new ProductType()
            {
                ProductTypeName = productType.ProductTypeName
            };

            _productTypeDal.Add(newProductType);
        }

        [SecuredOperation(UserClaims.Admin)]
        public void Delete(int id)
        {
            var getProductTypeTuple = _productTypeDal.Get(pt => pt.Id == id);
            ProductType productType = getProductTypeTuple.Item1;
            if (productType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir ürün tipi bulunamadı");
            }

            getProductTypeTuple.Item2.Dispose();
            _productTypeDal.Delete(productType);
        }

        public ProductTypeVm Get(int id)
        {
            var getProductTypeTuple = _productTypeDal.Get(pt => pt.Id == id);
            ProductType productType = getProductTypeTuple.Item1;
            if (productType == null)
            {
                throw new IdNotFoundException("Girilen Idye ait bir ürün tipi bulunamadı");
            }

            ProductTypeVm productTypeVm = new ProductTypeVm()
            {
                ProductTypeName = productType.ProductTypeName,
                Id=productType.Id
                
            };
            getProductTypeTuple.Item2.Dispose();
            return productTypeVm;
        }

        public List<ProductTypeVm> GetAll()
        {
            var getAllProductTypeTuple = _productTypeDal.GetAll();
            List<ProductType> productTypes = getAllProductTypeTuple.Item1;
            List<ProductTypeVm> ProductTypeVmList = new List<ProductTypeVm>();

            foreach (ProductType item in productTypes)
            {
                ProductTypeVm productTypeVm = new ProductTypeVm()
                {
                    ProductTypeName = item.ProductTypeName,
                    Id = item.Id
                };
                ProductTypeVmList.Add(productTypeVm);
            }

            getAllProductTypeTuple.Item2.Dispose();
            return ProductTypeVmList;
        }

        public List<ProductTypeVm> GetAllByExpression(Expression<Func<ProductType, bool>> expression)
        {
            var getAllProductTypeTuple = _productTypeDal.GetAll(expression);
            List<ProductType> productTypes = getAllProductTypeTuple.Item1;
            List<ProductTypeVm> ProductTypeVmList = new List<ProductTypeVm>();

            foreach (ProductType item in productTypes)
            {
                ProductTypeVm productTypeVm = new ProductTypeVm()
                {
                    ProductTypeName = item.ProductTypeName,
                    Id = item.Id
                };
                ProductTypeVmList.Add(productTypeVm);
            }
            getAllProductTypeTuple.Item2.Dispose();
            return ProductTypeVmList;
        }

        public ProductTypeVm GetByName(string name)
        {
            var getProductTypeTuple = _productTypeDal.Get(p => p.ProductTypeName == name);
            ProductType productType = getProductTypeTuple.Item1;
            if (productType == null)
            {
                throw new NotFoundException("Gönderilen isme ait ürün tipi bulunamadı.");
            }
            ProductTypeVm productTypeVm = new ProductTypeVm()
            {
                Id = productType.Id,
                ProductTypeName = productType.ProductTypeName
            };
            getProductTypeTuple.Item2.Dispose();
            return productTypeVm;
        }

        [SecuredOperation(UserClaims.Admin)]
        [ValidationAspect(typeof(ProductTypeUpdateValidator))]
        public void Update(ProductTypeUpdateDto productType)
        {
            ProductType productTypeUpdated = new ProductType()
            {
                Id = productType.Id,
                ProductTypeName = productType.ProductTypeName
            };

            _productTypeDal.Update(productTypeUpdated);
        }
    }

}
