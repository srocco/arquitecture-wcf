using PoC.Entities;
using PoC.Entities.Criteria;
using System.Collections.Generic;

namespace PoC.Data {

    public class ProductData {
        public List<Product> GeyByCriteria(ProductCriteria productCriteria) {
            var items = new List<Product>();
            for (int i = 0; i < 10; i++) {
                items.Add(new Product { Name = "Producto " + i.ToString() });
            }
            return items;
        }
    }
}
