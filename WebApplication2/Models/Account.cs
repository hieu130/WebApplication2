using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime DisabledAt { get; set; }
        public string Address { get; set; }
        public string Thumbnail { get; set; }
        public string PhoneNumber { get; set; }
        public int Status { get; set; }
        public string RoleNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime AddmissionDate { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}