﻿using Microsoft.EntityFrameworkCore;

namespace JuhMesquitaViagens.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Destiny> Destiny { get; set; }
        public DbSet<Package> Package { get; set; }
    }
}
