using ClinicaOdontologica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Data
{
    public class DataBase
    {
        private static List<Paciente> pacientes;
        private static List<Procedimento> procedimentos;

        private static DataBase instance;

        public static DataBase Instance()
        {
            if (instance == null)
            {
                pacientes = new List<Paciente>();
                procedimentos = new List<Procedimento>();

                instance = new DataBase();
            }
            return instance;
        }

        public void AddPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void RemovePaciente(int id)
        {
            Paciente removerPaciente = pacientes.Where(p => p.id == id).FirstOrDefault();
            pacientes.Remove(removerPaciente);
        }

        public void AddProcedimento(Procedimento procedimento)
        {
            procedimentos.Add(procedimento);
        }

        public void RemoveProcedimento(int id)
        {
            Procedimento removerProcedimento = procedimentos.Where(p => p.id == id).FirstOrDefault();
            procedimentos.Remove(removerProcedimento);
        }

        public List<Paciente> GetAllPacientes()
        {
            return pacientes;
        }

        public List<Procedimento> GetAllProcedimentos()
        {
            return procedimentos;
        }
    }
}
