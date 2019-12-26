using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;



namespace AwsomeMovies.Controllers
{
    public class MovieHomeController: Controller
    {
        public IActionResult Index()
        {            
           return View();
        }
        public String Welcome(string name,int visitedtimes=1)
        {

            return (System.Diagnostics.Process.GetCurrentProcess().ProcessName);
        }

    }
}
