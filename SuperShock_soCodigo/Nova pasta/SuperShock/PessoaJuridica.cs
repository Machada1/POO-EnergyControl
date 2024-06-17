using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShock
{
    public class PessoaJuridica : Pessoa{
        public PessoaJuridica(string nome, string cnpj) : base(nome, cnpj) { }
    }
}
