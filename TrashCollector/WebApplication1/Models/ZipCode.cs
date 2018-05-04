﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ZipCode
    {
        [Key]
        public int ID { get; set; }

        public string Code { get; set; }
    }
}