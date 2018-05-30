using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class ProgramContext : DbContext
    {
        public static ProgramContext context = new ProgramContext();

        public DbSet<InProgress> InProgress { get; set; }
        public DbSet<NotDelivered> NotDelivered { get; set; }
        public DbSet<Delivered> Delivered { get; set; }


    }
}
