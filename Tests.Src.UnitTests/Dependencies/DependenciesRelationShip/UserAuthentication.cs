using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies.DependenciesRelationShip
{
    public class UserAuthentication
    {
        public bool IsAuthenticated { get;  private set; }
        public void Login(string username, string password)
            => IsAuthenticated = true;
    }
}
