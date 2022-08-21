using Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_CPF")]
        public int CPF { get; set; }
        [Column("USR_TIPO")]
        public TipoUsuario? Tipo { get; set; }
    }
}
