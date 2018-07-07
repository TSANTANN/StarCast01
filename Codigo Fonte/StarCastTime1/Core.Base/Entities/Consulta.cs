using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Entities
{
    public class Consulta : EntidadeBase
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public Agendamento Agendamento { get; set; }

        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public  bool Update(Consulta consulta)
        {
            if (this.Id == consulta.Id)
            {
                this.Id = consulta.Id;
                this.Medico = consulta.Medico;
                this.Paciente = consulta.Paciente;
                this.Agendamento = consulta.Agendamento;

                return true;
            }
            return false;
        }
    }
}
