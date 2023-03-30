using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiThrottling
{
    public enum ThrottlePolicyType : int
    {
        IpThrottling = 1,
        ClientThrottling,
        EndpointThrottling
    }
}
