using System.Linq;
using CronogramaCursosWEB.Models;

namespace CronogramaCursosWEB.Dados {
    public class IniciarBanco {
        public static void Inicializar (CronogramaContexto contexto) {
            contexto.Database.EnsureCreated ();
            if (contexto.Areas.Any ()) {
                return;
            }
            var areas = new Areas() {NomeArea = "Administracao"};
            var cursos = new Cursos() {IDArea = areas.IDArea, NomeCurso = "Excell Avançado"};
            var turmas = new Turmas() {IDCurso= cursos.IDCurso, HorarioInicio = "10:00",  };
        }
    }
}