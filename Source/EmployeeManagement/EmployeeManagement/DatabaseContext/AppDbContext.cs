﻿using EmployeeManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public AppDbContext() : base(new DbContextOptions<AppDbContext>())
        {
        }
    }
}
