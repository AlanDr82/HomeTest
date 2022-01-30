using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CGIHomeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CGITestController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private static string thePostedString;
        public CGITestController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            string myLowerCaseString = thePostedString.ToLower();
            string[] splitedArray = Regex.Split(myLowerCaseString, "\\W+");

            foreach (string word in splitedArray)
            {
                if (myDictionary.ContainsKey(word))
                {
                    myDictionary[word] += 1;
                }
                else
                {
                    myDictionary[word] = 1;
                }
            }

            var mySortedDictionary = myDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            mySortedDictionary = mySortedDictionary.Take(9).ToDictionary(x => x.Key, x => x.Value);
            return new JsonResult(mySortedDictionary);

        }

        [HttpPost]
        public JsonResult Post([FromBody] string dep)
        {
            thePostedString = dep;

            return new JsonResult("Added successfully");
        }
    }
}
