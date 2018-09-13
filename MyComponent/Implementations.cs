using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupDIRegistrationsInNetCore.MyComponent
{
    public class ProductManager : IProductManager
    {
        public string HelloWorld => "Hello world from Product Manager";
    }

    public class BasketManager : IBasketManager
    {
        public string HelloWorld => "Hello world from Basket Manager";
    }
}
