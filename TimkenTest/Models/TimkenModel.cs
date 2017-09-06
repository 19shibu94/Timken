using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimkenTest.Models
{
    public class TimkenModel
    {
        public int id { get; set; }
        public string JobId { get; set; }
        public int DesignationId { get; set; }
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public string JobDescription { get; set; }
    }
}