using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiThrottling
{
    public class ThrottlePolicyWhitelistConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("entry", IsRequired = true)]
        public string Entry
        {
            get
            {
                return this["entry"] as string;
            }
        }

        [ConfigurationProperty("policyType", IsRequired = true)]
        public int PolicyType
        {
            get
            {
                return (int)this["policyType"];
            }
        }
    }
}
