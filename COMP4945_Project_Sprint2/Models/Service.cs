using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP4945_Project_Sprint2.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public double Price { get; set; }
        public string ServiceName { get; set; }

        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        
        public virtual Unit Unit { get; set; }
    }
}
