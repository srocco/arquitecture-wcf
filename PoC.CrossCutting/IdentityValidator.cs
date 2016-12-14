using System;
using System.Diagnostics;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace PoC.CrossCutting {
    public class IdentityValidator : UserNamePasswordValidator {

        public override void Validate(string userName, string password) {

            Debug.WriteLine("IdentityValidator -  Check user name");

            if ((userName != "user") || (password != "pass")) {

                Debug.WriteLine("IdentityValidator - Password Wrong!");

                var msg = String.Format("Unknown Username {0} or incorrect password {1}", userName, password);
                Trace.TraceWarning(msg);
                throw new FaultException(msg);
            }
            else {
                Debug.WriteLine("IdentityValidator - Password Correct!");
            }
        }
    }
}