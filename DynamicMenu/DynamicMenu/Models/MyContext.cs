using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMenu.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DynamicMenuEntities")
        {

        }
        public DbSet<MenuMaster> MenuMasters { get; set; }
    }
}