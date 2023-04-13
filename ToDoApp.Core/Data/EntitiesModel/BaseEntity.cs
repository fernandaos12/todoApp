using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todoApp.Data.EntitiesModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}