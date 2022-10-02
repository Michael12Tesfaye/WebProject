﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Buy_And_Sell.Models
{
    public class House
    {

        [Key]
        public int HouseId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public int NumberOfBedRooms { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Discription { get; set; }
        [Required]
        public string Image { get; set; }
        [Display(Name = "Owner Name")]
        public string SellerName { get; set; }

    }
}
