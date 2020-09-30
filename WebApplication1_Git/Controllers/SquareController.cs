using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1_Git.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// public int implies an integer that is available to the public
        /// get(int id) indicates that we are making a get request for the integer id
        /// int square =(int id)names and defines an integer, in this case, naming it square 
        /// and defining it as (id*id)
        /// return square simply returns the square of the id entered
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/square/5
        public int Get(int id)
        {
            int square =  (id*id);
            return square;
        }

        
    }
}
//<results>Success the square of the id is displayed </results>