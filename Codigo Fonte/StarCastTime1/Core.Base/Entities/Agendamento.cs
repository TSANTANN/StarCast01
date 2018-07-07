using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core.Base.Entities
{
    public class Agendamento : EntidadeBase
    {
        [Required(ErrorMessage = "O campo Data e Hora é obrigatório.")]
        public string DataHora { get; set; }
        public Especialidade Especialidade { get; set; }
        public Medico Medico { get; set; }


        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public  bool Update(Agendamento agendamento)
        {
            if (this.Id == agendamento.Id)
            {
                this.Id = agendamento.Id;
                this.DataHora = agendamento.DataHora;
                this.Especialidade = agendamento.Especialidade;
                this.Medico = agendamento.Medico;

                return true;
            }
            return false;
        }
    }
}
