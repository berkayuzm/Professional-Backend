// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore.Query.Internal;

//ProductTest();
//OrderTest();
//CategoryTest();
Counter();
static void Counter()
{
    for (int i = 0; i < 32123456; i++)
    {
        Console.WriteLine(i);
    }
}
static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    var categoryList = categoryManager.GetAll();
    foreach (var category in categoryList)
    {
        Console.WriteLine(category.CategoryName);
    }
}
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var data = productManager.GetAllByCategoryId(1);
    Console.WriteLine(data.Message);
    foreach (var product in data.Data)
    {
        Console.WriteLine(product.ProductName);

    }
}

static void OrderTest()
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());
    var orderList = orderManager.GetAll();
    foreach (var order in orderList)
    {
        Console.WriteLine(order.OrderId);
    }
}