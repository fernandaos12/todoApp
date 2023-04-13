using System;

namespace todoApp.Models
{
    public class CategoriesModel 
    {
        public int Id { get; set; }
        public String Type { get; set; }
        public String Category { get; set; }
        public ToDoModel ToDo { get; set; }
    }
}
