using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class ServiceDetail
    {
        public int ServiceDetailId { get; set; }

        public string DetailTitle { get; set; }
        public string DetailDescription { get; set; }
        public string DetailIcon { get; set; }  
    }
}