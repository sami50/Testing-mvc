using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_testing.Models;

namespace Test_testing
{
    public class DBcontext:DbContext
    {

        public DBcontext(DbContextOptions<DBcontext>options):base(options)
        {

        }
       public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Test> Tests { get; set; }

    }
}
