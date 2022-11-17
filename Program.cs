using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMedico
{
    class Program
    {
        static void Main(string[] args)
        {
            var med = new Medico()
            {
                ID = 1,
                Nome = "Rodrigo",
                Pacientes = new List<Paciente>
                {
                    new Paciente
                    {
                        ID = 1,
                        NomePaciente="Maria",
                        ValorConsulta=150
                    },
                    new Paciente
                    {
                        ID = 2,
                        NomePaciente="Jessica",
                        ValorConsulta=180,
                        Remedios = "Simeco Plus"
                    },
                    new Paciente
                    {
                        ID = 3,
                        NomePaciente="Veronica",
                        ValorConsulta=444,
                        Remedios = "Neosaldina"
                    },
                    new Paciente
                    {
                        ID = 4,
                        NomePaciente="Bruna",
                        ValorConsulta=1500,
                        Internado = true,
                        Historico = "Gota no Joelho"
                    },
                    new Paciente
                    {
                        ID = 5,
                        NomePaciente="Lorena",
                        Internado = true,
                        Remedios = "Rivotril",
                        Historico = "Cirurgia Bariátrica"
                    },
                }
            };
            var med2 = new Medico()
            {
                ID = 2,
                Nome = "Ricardo"
            };

            // caso for nulo retorna zero
            WriteLine($"Dr(a) {med2.Nome} tem {med2.Pacientes?.Count() ?? 0} pacientes");
            WriteLine();
            WriteLine();

            WriteLine($"Dr(a) {med.Nome} \n\n ---- Histórico dos pacientes ---- ");

            //paciente diferente de nulo                                   se remedio = 0
            med.Pacientes?.ForEach(p => WriteLine($"----{p.NomePaciente} - remédios: {p.Remedios ?? "Sem Remédios"} - Histórico {p.Historico}  ----  COnsulta: {p.ValorConsulta:n2}"));
            WriteLine();
            WriteLine();

            WriteLine($"Faturamento da Clínica: {med.Pacientes?.Sum(v => v.ValorConsulta):n2}");
            WriteLine();

            WriteLine($"Quantidade de Internados: {med.Pacientes?.Count(i => i.Internado)}");
            WriteLine();

            WriteLine($"Pacientes tomando remédio: {med.Pacientes?.Count(r => r.Remedios != null)}");

            foreach (var remedios in med.Pacientes.Where(r => r.Remedios != null))
            {
                WriteLine($"------ Paciente: {remedios.NomePaciente} ---- Remédio: {remedios.Remedios}");
            }

            ReadLine();
        }
    }
}