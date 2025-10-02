using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reserva_de_sala_dsm.Models
{
    [Table("Usuarios")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage ="O E-mail é Obrigatótio")]
        [EmailAddress(ErrorMessage ="O E-mail informado não é válido")]
        [StringLength(100, ErrorMessage ="O E-mail deve ter no máximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage ="A Senha é Obrigatória")]
        public bool Admnistrador { get; set; }
    }
}
