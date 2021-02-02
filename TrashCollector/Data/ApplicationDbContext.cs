﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole  // THIS DOES NOT WORK !!!!!!!
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            });
        }
        public DbSet<Customers> CustomersTable { get; set; }
        public DbSet<Employees> EmployeesTable { get; set; }
        public DbSet<Calendar> CalenderTable { get; set; }
        public DbSet<Payment> PaymentTable { get; set; }

    }
}
