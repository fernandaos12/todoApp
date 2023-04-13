using System;
using System.Collections.Generic;

namespace todoApp.Data.EntitiesModel
{
    public class Categories : BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public List<ToDo> ToDos { get; set; }
        public int ToDoId { get; set; }
    }
}
