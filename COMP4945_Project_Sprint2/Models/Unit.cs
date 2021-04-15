using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4945_Project_Sprint2.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public double Price { get; set; }
        public bool Appliance { get; set; }
        public bool IsOccupied { get; set; }
    }
}