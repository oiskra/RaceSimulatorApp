﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSemestralnyOOP.DBcontext
{
    public class RacingDBContextFactory : IDesignTimeDbContextFactory<RacingDBContext>
    {
        public RacingDBContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RacingDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RacingDatabase;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new RacingDBContext(optionsBuilder.Options);
        }
    }
}