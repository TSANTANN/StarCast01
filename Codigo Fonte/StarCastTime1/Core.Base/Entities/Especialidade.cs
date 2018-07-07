using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Entities
{
    public class Especialidade : EntidadeBase
    {
        [Required(ErrorMessage = "O campo Data e Hora é obrigatório.")]
        public string Descricao { get; set; }


        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public bool Update(Especialidade especialidade)
        {
            if (this.Id == especialidade.Id)
            {
                this.Id = especialidade.Id;
                this.Descricao = especialidade.Descricao;

                return true;
            }
            return false;
        }
    }
}
