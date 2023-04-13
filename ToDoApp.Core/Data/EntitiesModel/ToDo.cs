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
        [DisplayName("Titulo")]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Campo Obrigatório")]
        public string Title{ get; set; }
        public Status Status { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }             
        public int ToDo_Id { get; set; }             
        public string CategoryId { get; set;}
        public List<Categories> categories { get; set;}
      
    }
}