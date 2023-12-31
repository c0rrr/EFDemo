﻿using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace EFDemo.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext (DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }
}