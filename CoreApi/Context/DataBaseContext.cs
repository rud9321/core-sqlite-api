using System;
using CoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
