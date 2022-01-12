using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Employe
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile  IFromImage { get; set; }
        public int MyProperty { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        
    }
}
