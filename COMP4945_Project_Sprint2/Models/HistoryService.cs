using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4945_Project_Sprint2.Models
{
    public class HistoryService
    {
        [Key]
        public int HistoryServiceId { get; set; }
        public string ServiceName { get; set; }
        public double ServicePrice { get; set; }
        [ForeignKey("History")]
        public int HistoryId { get; set; }
        public virtual History History { get; set; }
    }
}
