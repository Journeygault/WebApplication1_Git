using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1_Git.Controllers
{
    public class GreetingIDController : ApiController
    {
       
        /// <summary>
        /// public sting: is a string open to the public 
        /// Get: ind;icates the type of request
        /// (int id) indicates that the Getr request can be for Integers or ID
        /// String A: defines the string A as the message "greetings to " + the ID indicate + " people!"
        /// Return A: defines the string being returned 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/GreetingID/5
        public string Get(int id)
        {
            string A = ("Greetings to " +id+" people!");

            return A;
        }

        
    }
}
//<results> Success, The message "Greetings to {id} people! is displayed </results>