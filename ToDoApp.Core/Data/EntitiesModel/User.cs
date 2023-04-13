using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApp.Data.EntitiesModel
{
    public class User : BaseEntity
    {
        public string Name{ get; set; }
        public string Email{ get; set; }     
        public List<ToDo> ToDos{ get; set; }
        public int ToDoId{ get; set; }
    }
}