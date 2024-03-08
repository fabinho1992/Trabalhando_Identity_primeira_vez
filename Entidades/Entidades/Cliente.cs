using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("Tb_Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage ="Máximo de caracteres é 100")]
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

    }
}
