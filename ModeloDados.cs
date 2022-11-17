using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMedico
{
    public class Medico
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public List<Paciente> Pacientes { get; set; }
    }

    public class Paciente
    {
        public int ID { get; set; }
        public string NomePaciente { get; set; }
        public string Historico { get; set; } = "nada relatado";
        public string Remedios { get; set; }
        public decimal ValorConsulta { get; set; } = 0;
        public bool Internado { get; set; }
    }
}