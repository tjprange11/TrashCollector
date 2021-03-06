﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [Display(Name = "Regular Pick Up Day")]
        public string RegularPickUpDay { get; set; }

        [Display(Name = "Extra Pick Up Day")]
        public string ExtraPickUpDay { get; set; }
    }
}