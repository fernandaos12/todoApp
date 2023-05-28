using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApp.Models
{
    public class User
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Email{ get; set; }     
        public List<ToDo> ToDos{ get; set; }
    }
}