using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupDIRegistrationsInNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MyComponent.IProductManager productManager;
        private readonly MyComponent.IBasketManager basketManager;

        public ValuesController(MyComponent.IProductManager productManager, MyComponent.IBasketManager basketManager)
        {
            this.productManager = productManager;
            this.basketManager = basketManager;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { productManager.HelloWorld, basketManager.HelloWorld };
        }

    }
}
