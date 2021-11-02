using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp.Shared.Models
{
   public class Pessoa
   {
      [Key]
      public int Id { get; set; }
      [Required]
      public string Nome { get; set; }
      [Required]
      public int Peso { get; set; }
   }
}
