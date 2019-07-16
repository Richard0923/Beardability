using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Data
{
    public class ECommDbContext: DbContext
    {
        public ECommDbContext(DbContextOptions<ECommDbContext> options) : base(options)
        {

        }


    }
}
