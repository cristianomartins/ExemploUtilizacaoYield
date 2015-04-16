using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
    }

    public class CntrCliente
    {
        public IEnumerable<Cliente> ListaClientesAcimaDe20Anos()
        {
            List<Cliente> BancoDeDados = new List<Cliente>()
            {
                new Cliente() {Id = 1, Nome = "Cliente 1", Idade = 40 },
                new Cliente() {Id = 2, Nome = "Cliente 2", Idade = 20 },
                new Cliente() {Id = 3, Nome = "Cliente 3", Idade = 16 },
                new Cliente() {Id = 4, Nome = "Cliente 4", Idade = 26 },
                new Cliente() {Id = 5, Nome = "Cliente 5", Idade = 28 },
                new Cliente() {Id = 7, Nome = "Cliente 6", Idade = 22 }
            };

            foreach (Cliente cliente in BancoDeDados)
            {
                if (cliente.Idade > 20)
                    yield return cliente;
            }
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            CntrCliente cntrCliente = new CntrCliente();

            foreach (Cliente cliente in cntrCliente.ListaClientesAcimaDe20Anos())
            {
                Console.WriteLine(String.Format("{0} - {1} - {2}", cliente.Id, cliente.Nome, cliente.Idade));
            }
            Console.ReadKey();
        }
    }
}