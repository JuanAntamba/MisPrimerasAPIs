using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MisPrimerasAPIs.Models;

    public class SQLServer : DbContext
    {
        public SQLServer (DbContextOptions<SQLServer> options)
            : base(options)
        {
        }

        public DbSet<MisPrimerasAPIs.Models.Cuenta> Cuenta { get; set; } = default!;
    }
