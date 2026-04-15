using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LH_PET_WEB.Models
{
    [Table("tb_Cliente")]
    public class Cliente
    {
       [Key] 
       [Column("pk_cliente")] 
       public int Id { get; set; }

       [Required] 
       [Column("fk_usuario")] 
       public int UsuarioId { get; set; } 

       [Required(ErrorMessage = "O Nome é obrigatório.")]
       [MaxLength(255)]
       [Column("nm_cliente")]
       public string Nome { get; set; } = string.Empty;

       [Required(ErrorMessage = "O CPF é obrigatório.")]
       [MaxLength(14)]
       [Column("nr_cpf")]
       public string CPF { get; set; } = string.Empty;

       [Required(ErrorMessage = "O Telefone é obrigatório.")]
       [MaxLength(20)]
       [Column("nr_telefone")]
       public string Telefone { get; set; } = string.Empty;

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

        public ICollection<Pet>? Pets { get; set; } = new List<Pet>();
    }
}