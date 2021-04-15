using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4945_Project_Sprint2.Models
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }

        [ForeignKey("Unit")]
        public int UnitId { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double TotalPrice { get; set; }

        public virtual Client Client { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
