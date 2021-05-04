using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionEFCore.API.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }

        public int IdEmp { get; set; }

        [Display(Name = "Salario Mensual")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal GrossSalary { get; set; }
    }
}
