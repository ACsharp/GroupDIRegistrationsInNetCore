using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupDIRegistrationsInNetCore.MyComponent
{
    public interface IProductManager
    {
        string HelloWorld { get; }
    }

    public interface IBasketManager
    {
        string HelloWorld { get; }
    }
}
