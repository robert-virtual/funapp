using funapp.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace funapp.Models
{
    public class FacecuteContext:DbContext
    {
        public FacecuteContext():base("FacecuteDb")
        {
            Database.SetInitializer(new FacecuteDbInitializer());
        }
        public DbSet<Client> Clients { get; set; }
    }
}
