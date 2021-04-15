using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4945_Project_Sprint2.Models
{
    public class Client
    {
        [Key]
        // pk client id
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}