using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using todoApp.Enums;

namespace todoApp.Models
{
    public class ToDoModel
    { 
        [DisplayName("Titulo")]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Campo Obrigatório")]
        public string Title{ get; set; }
        public Status Status { get; set; }
        public UserModel User { get; set; }
        public string UserId { get; set; }             
        public int ToDo_Id { get; set; }             
        public string CategoryId { get; set;}
        public List<CategoryModel> categories { get; set;}
      
    }
}