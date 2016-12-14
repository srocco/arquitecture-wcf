using PoC.Entities;
using PoC.Entities.Criteria;
using PoC.Services.Contracts;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;

namespace PoC.Services.Implementations {

    [PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
    public class BaseService  {
    }

      
    //[PrincipalPermission(SecurityAction.Demand, Role = "Customer")]
    public class ProductService : BaseService, IProductService {
        public List<Product> GeyByCriteria(ProductCriteria productCriteria) {
            Debug.WriteLine("Calling ProductService");
            var items = new List<Product>();
            for (int i = 0; i < 10; i++) {
                items.Add(new Product { Name = "Producto " + i.ToString() });
            }
            return items;
        }
    }
}