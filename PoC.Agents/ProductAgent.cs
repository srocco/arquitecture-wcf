using PoC.Services.Contracts;
using System.ServiceModel;

namespace PoC.Agents {
    public class ProductAgent {

        public static IProductService Instance() {
            var chf = new ChannelFactory<IProductService>("BasicHttpBinding_IProductService");
            chf.Credentials.UserName.UserName = "test";
            chf.Credentials.UserName.Password = "tttttttt";
            IProductService prox = chf.CreateChannel();
            return prox;
        }
    }
}