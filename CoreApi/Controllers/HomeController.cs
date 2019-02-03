using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using CoreApi.Context;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private DataBaseContext _dataBaseContext;
        public HomeController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        // GET: /<controller>/

        public IActionResult Index()
        {
            int j = 0;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Parallel.For(0,10,i=>
            {
                j++;
            });
            stopWatch.Stop();
            var count = stopWatch.Elapsed;
            return Ok(_dataBaseContext.Students.ToList());
        }
        [HttpPost]
        [Route("add-student")]
        public IActionResult AddStudent(Student student)
        {
            _dataBaseContext.Students.Add(student);
            _dataBaseContext.SaveChanges();
            return Ok(student);
        }
    }
}
