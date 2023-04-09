using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApp.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Name{ get; set; }
        public String Email{ get; set; }
        public DateTime CreatedAt{ get; set; } = DateTime.Now;
    }
}