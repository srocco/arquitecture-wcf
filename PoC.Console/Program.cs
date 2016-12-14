using PoC.Entities.Criteria;
using PoC.Services.Contracts;
using PoC.Services.Implementations;
using System;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PoC.Console {
    class Program {
        static void Main(string[] args) {
            //TestService();

            
            ProductCriteria productCriteria = new ProductCriteria();
            HttpServices.ProductServiceClient r = new HttpServices.ProductServiceClient();
            r.ClientCredentials.UserName.UserName = "test";
            r.ClientCredentials.UserName.Password = "tttttttt";

            r.GeyByCriteria(productCriteria);
            

            var chf = new ChannelFactory<IProductService>("DefaultBinding_RealWorld");
            chf.Credentials.UserName.UserName = "test";
            chf.Credentials.UserName.Password = "tttttttt";

            IProductService prox = chf.CreateChannel();

            var items = prox.GeyByCriteria(productCriteria);
        }

        private static void TestService() {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            GenericPrincipal principal = new GenericPrincipal(System.Threading.Thread.CurrentPrincipal.Identity,
                                                             new string[] { "Customer" });
            System.Threading.Thread.CurrentPrincipal = principal;

            ProductService service = new ProductService();
            service.GeyByCriteria(null);
        }
    }
}
