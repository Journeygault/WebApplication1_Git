using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1_Git.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// public: indicates that the following is accessible to the public
        /// int implies: it is an integer
        /// Get: indicates the type of HTTP request as well as
        /// what type of information to retrieve (in this case an integer or an id)
        /// int: is indicating and defining an integer called sum
        /// Sum is the ID + 10
        /// Return, is returning the Sum integer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/AddTen/5
        public int Get (int id)
        {
            int sum = id + 10;
            return sum ;
        }
      
    }
}
//<results> success, the number displayed in the browser is 10+ the indicated id</results>