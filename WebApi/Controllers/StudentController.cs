using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class StudentController : ApiController
    {
        public Student Get()
        {

            return new Student
            {
                Name = "Shariful Islam",
                Address = "Dhaka"
            };
           
        }

        public Student Get(int id)
        {
            return new Student
            {
                Name = "Akbar Islam",
                Address = "Dhaka,Bangladesh"
            };
        }

        public Student Post(Student ainfo)
        {
            return ainfo;
        }

        //[Route("api/Student/GetOnlyName")]
        //public string GetOnlyName()
        //{

        //    return "Shaon";
        //}
    }
}
