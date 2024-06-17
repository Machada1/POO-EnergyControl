using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShock
{
    public class Pessoa{
        public string Nome { get; set; }
        public string Identificador { get; set; } // CPF ou CNPJ
        public List<ContaDeEnergia> Contas { get; set; } = new List<ContaDeEnergia>();

        public Pessoa(string nome, string identificador)
        {
            Nome = nome;
            Identificador = identificador;
        }

        public void AdicionarConta(ContaDeEnergia conta)
        {
            Contas.Add(conta);
        }
    }
}
