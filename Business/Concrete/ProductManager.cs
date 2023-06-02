using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;   
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
           
            _productDal.Add(product);   
            return new SuccessResult("Ürün ekleme başarılı");
        }
        public IDataResult<List<Product>> GetAll()
        {
           return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"Sorgulama Başarılı!");
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(c => c.CategoryId == id), "sorgulama başarılı");
        }

        public IDataResult<List<Product>> GetByUnitPrice(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            throw new NotImplementedException();
        }
        public IDataResult<Product> GetById(int id) {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id), "sorgulama başarılı");
        
        }

       
    }
}
