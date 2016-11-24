using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace johnnyvideopage.Controllers
{
    public class ApiCallsController : Controller
    {
        // GET: ApiCalls
        public void IMDBCall()
        {
            string path = "http://www.omdbapi.com/?t=Titanic";
            
        }
    }
}