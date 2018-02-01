using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CronogramaCursosWEB.Models
{
    public class Cursos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCurso { get; set; }

        [Required]
        public int IDArea { get; set; }

        [Required]
        [StringLength(100, ErrorMessage="Insira no máximo 100 Caracteres")]
        public string NomeCurso { get; set; }

        public ICollection<Areas> Areas { get; set; }
    }
}