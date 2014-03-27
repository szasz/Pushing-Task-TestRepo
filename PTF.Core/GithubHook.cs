using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace PTF.Core
{
    public class GithubHook
    {
        /// <summary>
        /// Amikor elküldi a payload()-ot a szerver, ide fut be..
        /// </summary>
        public static void SendingToPayload(HttpContext context)
        {
            // feltételek, hogy csak milyen, honan érkező kérés megfelelő



        }

            //////            Request URL: http://git-trellopushingtaskfollower.apphb.com/Home/Hooks
            //////Request method: POST
            //////content-type: "application/json"
            //////Expect: ""
            //////User-Agent: "GitHub Hookshot a6bccf0"
            //////X-GitHub-Delivery: "a3690538-b133-11e3-9e6a-929e222e9f3b"
            //////X-GitHub-Event: "push"
    }
}
