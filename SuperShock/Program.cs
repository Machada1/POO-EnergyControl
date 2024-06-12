using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Importando a biblioteca System.Text.Json

namespace ControleDeEnergia
{
    public class Pessoa
    {
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

    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string cpf) : base(nome, cpf) { }
    }

    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string cnpj) : base(nome, cnpj) { }
    }

    public class ContaDeEnergia
    {
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

    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeContas gerenciador = new GerenciadorDeContas();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Cadastrar Consumidor");
                Console.WriteLine("2. Cadastrar Conta");
                Console.WriteLine("3. Consultar Consumo");
                Console.WriteLine("4. Consultar Valor Total");
                Console.WriteLine("5. Consultar Valor Sem Imposto");
                Console.WriteLine("6. Salvar Dados");
                Console.WriteLine("7. Carregar Dados");
                Console.WriteLine("8. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome do consumidor: ");
                        string nome = Console.ReadLine();
                        Console.Write("CPF/CNPJ do consumidor: ");
                        string identificador = Console.ReadLine();
                        Console.Write("Tipo de consumidor (1. Pessoa Física, 2. Pessoa Jurídica): ");
                        string tipo = Console.ReadLine();
                        Pessoa consumidor = tipo == "1" ? new PessoaFisica(nome, identificador) : new PessoaJuridica(nome, identificador);
                        gerenciador.CadastrarConsumidor(consumidor);
                        break;

                    case "2":
                        Console.Write("Tipo de conta (residencial/comercial): ");
                        string tipoConta = Console.ReadLine();
                        Console.Write("Leitura do mês atual: ");
                        double leituraMesAtual = double.Parse(Console.ReadLine());
                        Console.Write("Leitura do mês anterior: ");
                        double leituraMesAnterior = double.Parse(Console.ReadLine());
                        Console.Write("CPF/CNPJ do consumidor: ");
                        string identificadorConsumidor = Console.ReadLine();
                        ContaDeEnergia conta = new ContaDeEnergia(tipoConta, leituraMesAtual, leituraMesAnterior, identificadorConsumidor);
                        gerenciador.CadastrarConta(conta);
                        break;

                    case "3":
                        Console.Write("CPF/CNPJ do consumidor: ");
                        string identificadorConsultaConsumo = Console.ReadLine();
                        double? consumo = gerenciador.ConsultarConsumo(identificadorConsultaConsumo);
                        if (consumo.HasValue)
                        {
                            Console.WriteLine($"Consumo no último mês: {consumo} kW/h");
                        }
                        break;

                    case "4":
                        Console.Write("CPF/CNPJ do consumidor: ");
                        string identificadorConsultaValorTotal = Console.ReadLine();
                        double? valorTotal = gerenciador.ConsultarValorTotal(identificadorConsultaValorTotal);
                        if (valorTotal.HasValue)
                        {
                            Console.WriteLine($"Valor total da conta: R$ {valorTotal:F2}");
                        }
                        break;

                    case "5":
                        Console.Write("CPF/CNPJ do consumidor: ");
                        string identificadorConsultaValorSemImposto = Console.ReadLine();
                        double? valorSemImposto = gerenciador.ConsultarValorSemImposto(identificadorConsultaValorSemImposto);
                        if (valorSemImposto.HasValue)
                        {
                            Console.WriteLine($"Valor da conta sem imposto: R$ {valorSemImposto:F2}");
                        }
                        break;

                    case "6":
                        Console.Write("Nome do arquivo para salvar os dados: ");
                        string arquivoSalvar = Console.ReadLine();
                        gerenciador.SalvarDados(arquivoSalvar);
                        Console.WriteLine("Dados salvos com sucesso.");
                        break;

                    case "7":
                        Console.Write("Nome do arquivo para carregar os dados: ");
                        string arquivoCarregar = Console.ReadLine();
                        gerenciador.CarregarDados(arquivoCarregar);
                        Console.WriteLine("Dados carregados com sucesso.");
                        break;

                    case "8":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
