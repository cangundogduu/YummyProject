using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class ContactInfo
    {
        [Key]
        public int ContantInfoId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MapUrl { get; set; }
        public string OpenHours { get; set; }


    }
}