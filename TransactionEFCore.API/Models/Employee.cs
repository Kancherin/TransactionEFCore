using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionEFCore.API.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Empleado")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de {1} caracteres.")]
        public string Name { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de {1} caracteres.")]
        public string Departament { get; set; }

        [Display(Name = "Inicio de Actividad")]
        [MaxLength(50, ErrorMessage = "El {0} no puede tener mas de {1} caracteres.")]
        public string JoinDate { get; set; }
    }
}
