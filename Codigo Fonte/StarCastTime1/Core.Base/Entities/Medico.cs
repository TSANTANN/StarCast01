using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Entities
{
    public class Medico : UsuarioBase
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public List<Especialidade> Especialidade { get; set; }
        [Required(ErrorMessage = "O campo CRM é obrigatório.")]
        public string CRM { get; set; }
        public string DataNascimento { get; set; }
        public string RG { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CPF { get; set; }
        public string EnderecoComercial { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public bool Update(Medico medico)
        {
            if (this.Id == medico.Id)
            {
                this.Id = medico.Id;
                this.Nome = medico.Nome;
                this.Sexo = medico.Sexo;
                this.Especialidade = medico.Especialidade;
                this.CRM = medico.CRM;
                this.DataNascimento = medico.DataNascimento;
                this.RG = medico.RG;
                this.CPF = medico.CPF;
                this.EnderecoComercial = medico.EnderecoComercial;
                this.Telefone = medico.Telefone;
                this.Email = medico.Email;
                this.Senha = medico.Senha;
                this.Perfil = medico.Perfil;

                return true;
            }
            return false;
        }
    }
}
