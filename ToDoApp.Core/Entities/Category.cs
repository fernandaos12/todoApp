using System;
using System.Collections.Generic;

namespace ToDoApp.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public List<ToDo> ToDos { get; set; }
        public int ToDoId { get; set; }
    }
}
