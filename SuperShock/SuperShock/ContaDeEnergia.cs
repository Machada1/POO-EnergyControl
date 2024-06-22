using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShock
{
    public class ContaDeEnergia{
        public string Tipo { get; set; } // 'residencial' ou 'comercial'
        public double LeituraMesAtual { get; set; }
        public double LeituraMesAnterior { get; set; }
        public string IdentificadorConsumidor { get; set; }

        public ContaDeEnergia(string tipo, double leituraMesAtual, double leituraMesAnterior, string identificadorConsumidor)
        {
            Tipo = tipo;
            LeituraMesAtual = leituraMesAtual;
            LeituraMesAnterior = leituraMesAnterior;
            IdentificadorConsumidor = identificadorConsumidor;
        }

        public double Consumo => LeituraMesAtual - LeituraMesAnterior;

        public double ValorConsumo => Consumo * (Tipo == "residencial" ? 0.40 : 0.35);

        public double ValorTotal
        {
            get
            {
                double valorComIluminacao = ValorConsumo + 9.25;
                double imposto = Tipo == "residencial" ? 0.30 : 0.18;
                return valorComIluminacao * (1 + imposto);
            }
        }

        public double ValorSemImposto => ValorConsumo + 9.25;
    }
}
