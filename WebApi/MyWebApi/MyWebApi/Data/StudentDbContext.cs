﻿using Microsoft.EntityFrameworkCore;
using MyWebApi.Model;

namespace MyWebApi.Data
{
    public class StudentDbContext:DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
