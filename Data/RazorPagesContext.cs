﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPages.Models
{
    public class RazorPagesContext : DbContext
    {
        public RazorPagesContext (DbContextOptions<RazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages.Models.Movie> Movie { get; set; }
    }
}