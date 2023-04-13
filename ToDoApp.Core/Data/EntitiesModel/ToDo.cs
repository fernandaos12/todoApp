using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Core.Data.Enums;

namespace todoApp.Data.EntitiesModel
{
    public class ToDo : BaseEntity
    { 
        public string Title{ get; set; }
        public string Description{ get; set; }
        public Category Category{ get; set; }
        public DateTime Date {get; set; }
        public Status Status { get; set; }
        public User User { get; set; }
        public string TodoId { get; set; }             
      
    }
}