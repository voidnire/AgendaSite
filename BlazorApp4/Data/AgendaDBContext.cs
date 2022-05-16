using BlazorApp4.Data.Entities;
using System;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp4.Data
{
    public class AgendaDBContext : DbContext
    {
        public AgendaDBContext(DbContextOptions<AgendaDBContext> options) : base(options)
        {

        }

        public DbSet<Todo> {get; set;}
    }
}
