using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Bu interface Product ile ilgili veritabanı erişimi sağlayan classların türediği interface. Bu interface'i implement eden classlar 
    //farklı teknolojilere göre product bilgilerine erişim sağlarlar.
    public interface IProductDal:IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();

    }
}
