using System.Diagnostics;
using System.Security.Principal;
using System.ServiceModel;
using System.Threading;
using System.Linq;

namespace PoC.CrossCutting {
    public class RoleAuthorizationManager : ServiceAuthorizationManager {

        protected override bool CheckAccessCore(OperationContext operationContext) {
            //var roleNames = new string[] { "Customer" };
            var roleNames = new string[] { };
            var permission = new string[] { "GeyByCriteria" };
            
            Debug.WriteLine("RoleAuthorizationManager - CheckAccessCore");

            if (operationContext.ServiceSecurityContext.PrimaryIdentity == null) {
                Debug.WriteLine("RoleAuthorizationManager - Is Null");
            }
            else {
                Debug.WriteLine("RoleAuthorizationManager - " +
                    operationContext.ServiceSecurityContext.PrimaryIdentity.Name);

                Debug.WriteLine("RoleAuthorizationManager - IsAuthenticated " +
                   operationContext.ServiceSecurityContext.PrimaryIdentity.IsAuthenticated);
            }
            operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] =
                new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, roleNames);

            Thread.CurrentPrincipal = new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, roleNames);

            var action = OperationContext.Current.IncomingMessageHeaders.Action;
            var parts = action.Split('/');
            if (permission.Contains(parts[parts.Length - 1])) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
