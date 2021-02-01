using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Model
{
    public class Usuario
    {
        private int sequsuario;
        private string nome;
        private string login;
        private string senha;
        private bool ativo;
        private string ultnome;

        public int Sequsuario { get => sequsuario; set => sequsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Ultnome { get => ultnome; set => ultnome = value; }
    }
}
