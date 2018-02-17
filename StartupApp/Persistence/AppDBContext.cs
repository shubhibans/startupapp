using Microsoft.EntityFrameworkCore;
using StartupApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupApp.Persistence
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base (options)
        {

        }

        public DbSet<QuestionType> Questiontypes { get; set; }
    }
}
