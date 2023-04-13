using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApp.Models
{
    public class UserModel
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Email{ get; set; }     
        public List<ToDoModel> ToDos{ get; set; }
    }
}