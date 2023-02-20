using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace todoApp.Models
{
    public class ToDo
    {
        public int id{get;set;}
        
        [DisplayName("Titulo")]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Campo Obrigatório")]
        public string Title{ get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string User { get; set; }    
   
        
    }
}