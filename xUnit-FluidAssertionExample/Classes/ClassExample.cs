using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_FluidAssertionExample.Classes
{
    public class ClassExample
    {
        public int sumResult(int a, int b)
        {
            return a + b;
        }

        public string returnFoxIfZero(int a)
        {
            if (a == 0)
            {
                return "Fox";
            }
            else { return "Not a Fox"; }
        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1,
            };
        }

        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions()
                {
                    DontFragment= true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment= true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment= true,
                    Ttl = 1
                }
            };
            return pingOptions;
        }
    }
}
