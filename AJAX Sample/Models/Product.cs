﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AJAX_Sample.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range ( 1, 1000 ) ]
        [Required ( ErrorMessage = "Give a price")]
        public double Price { get; set; }


    }
}