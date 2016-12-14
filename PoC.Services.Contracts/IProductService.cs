using PoC.Entities;
using PoC.Entities.Criteria;
using System.Collections.Generic;
using System.ServiceModel;

namespace PoC.Services.Contracts {

    [ServiceContract]
    public interface IProductService {

        [OperationContract]
        List<Product> GeyByCriteria(ProductCriteria productCriteria);
    }
}