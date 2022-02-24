using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerEmployees.Models
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Salary { set; get; }
        public string Department { set; get; }
        public string Phone { set; get; }
    }
}