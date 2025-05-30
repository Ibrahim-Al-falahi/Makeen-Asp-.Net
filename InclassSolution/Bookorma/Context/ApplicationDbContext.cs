﻿using Bookorma.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookorma.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> books { get; set; }
    }
}
