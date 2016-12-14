using PoC.Data;
using PoC.Entities;
using PoC.Entities.Criteria;
using System.Collections.Generic;

namespace PoC.Business {
    public class ProductBusiness {
        public List<Product> GeyByCriteria(ProductCriteria productCriteria) {
            ProductData productData = new ProductData();
            return productData.GeyByCriteria(productCriteria);
        }
    }
}
