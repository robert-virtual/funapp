using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace funapp.models
{
    public class Client
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }

       
        
        [MaxLength(433)]
        public string Clave { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public Client()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
