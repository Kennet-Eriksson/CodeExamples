using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Todo.Models
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}