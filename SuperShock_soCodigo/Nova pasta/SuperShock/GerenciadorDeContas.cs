using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SuperShock
{
    public class GerenciadorDeContas
    {
        public Dictionary<string, Pessoa> Consumidores { get; set; } = new Dictionary<string, Pessoa>();

        public void CadastrarConsumidor(Pessoa consumidor)
        {
            Consumidores[consumidor.Identificador] = consumidor;
        }

        public void CadastrarConta(ContaDeEnergia conta)
        {
            if (Consumidores.TryGetValue(conta.IdentificadorConsumidor, out Pessoa consumidor))
            {
                consumidor.AdicionarConta(conta);
            }
            else
            {
                Console.WriteLine($"Consumidor com identificador {conta.IdentificadorConsumidor} não encontrado.");
            }
        }

        public double? ConsultarConsumo(string identificador)
        {
            if (Consumidores.TryGetValue(identificador, out Pessoa consumidor))
            {
                if (consumidor.Contas.Count > 0)
                {
                    return consumidor.Contas[^1].Consumo;
                }
                else
                {
                    Console.WriteLine("Nenhuma conta encontrada para o consumidor.");
                }
            }
            else
            {
                Console.WriteLine("Consumidor não encontrado.");
            }

            return null;
        }

        public double? ConsultarValorTotal(string identificador)
        {
            if (Consumidores.TryGetValue(identificador, out Pessoa consumidor))
            {
                if (consumidor.Contas.Count > 0)
                {
                    return consumidor.Contas[^1].ValorTotal;
                }
                else
                {
                    Console.WriteLine("Nenhuma conta encontrada para o consumidor.");
                }
            }
            else
            {
                Console.WriteLine("Consumidor não encontrado.");
            }

            return null;
        }

        public double? ConsultarValorSemImposto(string identificador)
        {
            if (Consumidores.TryGetValue(identificador, out Pessoa consumidor))
            {
                if (consumidor.Contas.Count > 0)
                {
                    return consumidor.Contas[^1].ValorSemImposto;
                }
                else
                {
                    Console.WriteLine("Nenhuma conta encontrada para o consumidor.");
                }
            }
            else
            {
                Console.WriteLine("Consumidor não encontrado.");
            }

            return null;
        }

        public void SalvarDados(string arquivo)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(Consumidores, options);
            File.WriteAllText(arquivo, json);
        }

        public void CarregarDados(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                var json = File.ReadAllText(arquivo);
                Consumidores = JsonSerializer.Deserialize<Dictionary<string, Pessoa>>(json);

                // Reconstituir as listas de contas
                foreach (var consumidor in Consumidores.Values)
                {
                    for (int i = 0; i < consumidor.Contas.Count; i++)
                    {
                        var conta = consumidor.Contas[i];
                        var contaReconstituida = new ContaDeEnergia(
                            conta.Tipo,
                            conta.LeituraMesAtual,
                            conta.LeituraMesAnterior,
                            conta.IdentificadorConsumidor
                        );
                        consumidor.Contas[i] = contaReconstituida;
                    }
                }
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado.");
            }
        }
    }
}
