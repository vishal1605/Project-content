using Dapper;
using experimentProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Diagnostics;

namespace experimentProject.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;

        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(string requestData)
        {
            dynamic? jsonData = JsonConvert.DeserializeObject(requestData);
            DateTime date = DateTime.Parse(jsonData["registerDate"].ToString());
             var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
             var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            Console.WriteLine(firstDayOfMonth);

            //var sqlPara = new
            //{
            //    email= jsonData["email"].ToString(),
            //    name = jsonData["name"].ToString(),
            //    psw = jsonData["psw"].ToString(),
            //    registerDate = DateTime.Parse(jsonData["registerDate"].ToString()),
            //    firstDay = DateTime.Parse(jsonData["firstDay"].ToString()),
            //    lastDay = DateTime.Parse(jsonData["lastDay"].ToString()),
            //};
            //Console.WriteLine(sqlPara);
            //string query = "insert into tbluser(email,name,psw, registerDate) values (@email, @name, @psw, @registerDate)";
            //SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            var row = 3 ;

            return new JsonResult(row);
        }
    }
}