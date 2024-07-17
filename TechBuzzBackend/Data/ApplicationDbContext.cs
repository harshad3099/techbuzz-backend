﻿namespace TechBuzzBackend.Data
using Microsoft.EntityFrameworkCore;
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
    }
}
