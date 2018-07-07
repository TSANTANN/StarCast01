using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base.Entities
{
    public class Paciente : UsuarioBase
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string RG { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        public bool IsValid
        {
            get { return Validator.TryValidateObject(this, new ValidationContext(this, null, null), null, true); }
        }

        public bool Update(Paciente paciente)
        {
            if (this.Id == paciente.Id)
            {
                this.Id = paciente.Id;
                this.Nome = paciente.Nome;
                this.Sexo = paciente.Sexo;
                this.DataNascimento = paciente.DataNascimento;
                this.RG = paciente.RG;
                this.CPF = paciente.CPF;
                this.Endereco = paciente.Endereco;
                this.Telefone = paciente.Telefone;
                this.Email = paciente.Email;
                this.Senha = paciente.Senha;
                this.Perfil = paciente.Perfil;
                return true;
            }
            return false;
        }
    }
}
