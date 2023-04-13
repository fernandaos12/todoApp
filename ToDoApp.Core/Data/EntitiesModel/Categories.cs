using System;

namespace todoApp.Data.EntitiesModel
{
    public class Categories : BaseEntity
    {
        public String Type { get; set; }
        public String Category { get; set; }
        public ToDo ToDo { get; set; }
    }
}
