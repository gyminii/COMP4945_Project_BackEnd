using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP4945_Project_Sprint2.Models;

namespace COMP4945_Project_Sprint2.Data
{
    public class COMP4945_Project_Sprint2Context : DbContext
    {
        public COMP4945_Project_Sprint2Context (DbContextOptions<COMP4945_Project_Sprint2Context> options)
            : base(options)
        {
        }

        public DbSet<COMP4945_Project_Sprint2.Models.Client> Client { get; set; }

        public DbSet<COMP4945_Project_Sprint2.Models.Unit> Unit { get; set; }

        public DbSet<COMP4945_Project_Sprint2.Models.History> History { get; set; }

        public DbSet<COMP4945_Project_Sprint2.Models.Service> Service { get; set; }

        public DbSet<COMP4945_Project_Sprint2.Models.HistoryService> HistoryService { get; set; }
    }
}
