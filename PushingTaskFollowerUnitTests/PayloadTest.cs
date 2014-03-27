using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.IO;
using PTF.Core;

namespace PushingTaskFollowerUnitTests
{
    [TestClass]
    public class PayloadTest
    {
        /// <summary>
        /// Az HttpContext-en keresztül átdobott, deszantos json adat.
        /// </summary>
        [TestMethod]
        public void PayloadTestPostJson()
        {
            string jsonText = File.ReadAllText(@"D:\DEV\Work\PushingTaskFollower\PushingTaskFollowerUnitTests\payload-sample.json");
            
            //HttpRequest req = new HttpRequest(jsonText, null, null);

            //HttpContext context = new HttpContext(null,null);

            // Itt összerakok egy teszt httpcontext-et

            //GithubHook.SendingToPayload(
            
            
            
            
            
            
            //var post = HttpPost("http://git-trellopushingtaskfollower.apphb.com/Home/Hooks", jsonText);


            
            //HttpRequest req = new HttpRequest("filename", "url", "querystring");
            //HttpContext context = new HttpContext(req, null);
            //context.Response.ContentType = "application/json";
            //var data = context.Request["data"];
            

            //////            Request URL: http://git-trellopushingtaskfollower.apphb.com/Home/Hooks
            //////Request method: POST
            //////content-type: "application/json"
            //////Expect: ""
            //////User-Agent: "GitHub Hookshot a6bccf0"
            //////X-GitHub-Delivery: "a3690538-b133-11e3-9e6a-929e222e9f3b"
            //////X-GitHub-Event: "push"

            
        }

        public static string HttpPost(string URI, string Parameters)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(URI);
            //req.Proxy = new System.Net.WebProxy(ProxyString, true);
            //Add these, as we're doing a POST
            req.ContentType = "application/json";
            req.Method = "POST";
            //We need to count how many bytes we're sending. Post'ed Faked Forms should be name=value&
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(Parameters);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length); //Push it out there
            os.Close();
            System.Net.WebResponse resp = req.GetResponse();
            if (resp == null) return null;
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
    }
}
