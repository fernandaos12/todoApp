﻿using System;

namespace todoApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string CategoryDescription { get; set; }
        public ToDo ToDo { get; set; }
    }
}
