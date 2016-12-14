using PoC.Fwk.Agents;
using PoC.Services.Contracts;
using System.ServiceModel;

namespace PoC.Agents {
    public class ProductAgent : AgentBase {

        public static IProductService Instance() {
            var chf = new ChannelFactory<IProductService>("BasicHttpBinding_IProductService");
            chf.Credentials.UserName.UserName = "user";
            chf.Credentials.UserName.Password = "pass";
            IProductService prox = chf.CreateChannel();
            return prox;
        }
    }
}