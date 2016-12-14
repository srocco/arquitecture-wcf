using System.Security.Permissions;

namespace PoC.Fwk.Services {

    [PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
    public class BaseService {
    }
}
