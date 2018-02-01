using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CronogramaCursosWEB.Models {
    public class Areas {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int IDArea { get; set; }

        [Required]
        [StringLength(200, ErrorMessage="Insira no máximo 200 caracteres")]
        public string NomeArea { get; set; }

        public Cursos Cursos { get; set; }
    }
}