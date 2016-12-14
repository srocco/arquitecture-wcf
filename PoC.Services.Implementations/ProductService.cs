using PoC.Business;
using PoC.Entities;
using PoC.Entities.Criteria;
using PoC.Fwk.Services;
using PoC.Services.Contracts;
using System.Collections.Generic;
using System.Diagnostics;

namespace PoC.Services.Implementations {

    //[PrincipalPermission(SecurityAction.Demand, Role = "Customer")]
    public class ProductService : BaseService, IProductService {
        public List<Product> GeyByCriteria(ProductCriteria productCriteria) {
            ProductBusiness productBusiness = new ProductBusiness();
            return productBusiness.GeyByCriteria(productCriteria);
        }
    }
}