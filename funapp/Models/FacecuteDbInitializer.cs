using funapp.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace funapp.Models
{
    public class FacecuteDbInitializer:DropCreateDatabaseIfModelChanges<FacecuteContext>
    {
        protected override void Seed(FacecuteContext context)
        {
            var client = new Client()
            {
                Name = "admin",
                Clave = Clave.Encrypt("admin")
            };
            context.Clients.Add(client);

            base.Seed(context);
        }
    }
}
