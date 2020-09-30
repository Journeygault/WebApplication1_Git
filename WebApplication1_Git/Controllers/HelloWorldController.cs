using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;

namespace WebApplication1_Git.Controllers
{
    public class HelloWorldController : ApiController
    {  
        /// <summary>
        /// Public Indicates that the information is publicly available
        /// IEnumerable implies that multiple strings can be generated from this post request
        /// <string> indicates that we are looking to recieve a strings 
        /// post() is indicating that this is a post request
        /// </summary>
        /// <returns></returns>
    // POST api/HelloWorld
         public IEnumerable <string> post()

        {
           return new string[] { "Hello World!" } ;

            
        }

       
    }
}
//<results>Hellow world displays when enterd through the comand prompt.
// The issue here Is I cant make this code work withought IEnumerable,
// But we only need one result here so Ienumerable is not required, 
//Further investigation is required</results>