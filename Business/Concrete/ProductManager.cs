using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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

        public IResult Add(Product product)
        {
            _productDal.Add(product);   
            return new SuccessResult("Ürün ekleme başarılı");
        }

        //public IResult Add(Product product)
        //{
        //    _productDal.Add(product);

        //    return new Result(true) ;
        //}

        //public List<Product> GetAll()
        //{
        //    //İş kodları olacak
        //    //if(userRole===Admin)
        //    //else{yetkiniz bulunmamaktadır.}
        //    return _productDal.GetAll();
        //}

        //public List<Product> GetAllByCategoryId(int id)
        //{
        //    return _productDal.GetAll(p => p.CategoryId == id);
        //}

        //public List<Product> GetByUnitPrice(int min, int max)
        //{
        //    return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        //}

        //public List<ProductDetailDto> GetProductDetails()
        //{
        //    return _productDal.GetProductDetails();
        //}

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
