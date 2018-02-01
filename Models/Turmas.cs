using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CronogramaCursosWEB.Models {
    public class Turmas {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int IDTurmas { get; set; }

        [Required]
        public int IDCurso { get; set; }

        [Required]
        [DataType (DataType.Time)]
        public DateTime HorarioInicio { get; set; }

        [Required]
        [DataType (DataType.Time)]
        public DateTime HorarioFim { get; set; }

        [Required]
        [StringLength (100)]
        public string Dias { get; set; }

        [Required]
        [DataType (DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType (DataType.Date)]
        public DateTime DataFim { get; set; }

    }
}