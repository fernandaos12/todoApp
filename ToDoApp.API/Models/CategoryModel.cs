﻿using System;

namespace todoApp.Models
{
    public class CategoryModel 
    {
        public int Id { get; set; }
        public String Type { get; set; }
        public String Category { get; set; }
        public ToDoModel ToDo { get; set; }
    }
}