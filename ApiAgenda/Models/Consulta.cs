using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAgenda.Models
{
    public class Consulta
    {
        public int Id { get; set; }

        public DateTime InicioConsulta { get; set; }

        public DateTime FimConsulta { get; set; }

        public string Observacao { get; set; }

        //public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }
    }
}
