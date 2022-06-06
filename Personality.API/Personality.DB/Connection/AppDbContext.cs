using Microsoft.EntityFrameworkCore;
using Personality.DB.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personality.DB.Connection
{
    public class AppDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }


    }
}
