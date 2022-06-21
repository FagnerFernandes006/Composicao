using Composicao.Entities.Enums;
using Composicao.Entities;
using System.Globalization;

namespace Composicao
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string departNome = Console.ReadLine();
            Console.WriteLine("Insira os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");

            LevelTrabalhador level = Enum.Parse<LevelTrabalhador>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(departNome);
            Trabalhador trabalhador = new Trabalhador(nome, level, salarioBase, departamento);

            Console.Write("Quantos contratos serão? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato #{i}");
                Console.Write("Data (DD/MM/YYYY): " );
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Dutação (Horas): ");
                int horas = int.Parse(Console.ReadLine());
                HorasContrato contrato = new HorasContrato(data, valorPorHora, horas);
                trabalhador.AdicionarContrato(contrato);
            }
            Console.Write("Entre com o mês e ano para calcular o ganho (MM/YYYY): ");   
            string MesAno = Console.ReadLine();
            int mes = int.Parse(MesAno.Substring(0, 2));
            int ano = int.Parse(MesAno.Substring(3));
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento);
            double ganho = trabalhador.Ganho(ano, mes);
            Console.WriteLine("Ganho " + MesAno + ": " + ganho);

        }
    }
}
