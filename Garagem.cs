using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Transportes
{
    internal class Garagem
    {
        // Atributos privados
        private int id;
        private string local;
        private List<Veiculo> veiculos;

        // Construtor
        public Garagem(int id, string local)
        {
            this.id = id;
            this.local = local;
            this.veiculos = new List<Veiculo>();
        }

        // Métodos públicos
        public int GetId()
        {
            return id;
        }

        public string GetLocal()
        {
            return local;
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(Veiculo veiculo)
        {
            veiculos.Remove(veiculo);
        }

        public List<Veiculo> ListarVeiculos()
        {
            return veiculos;
        }
    }
}