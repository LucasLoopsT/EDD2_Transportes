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
    internal class Viagem
    {
        // Atributos privados
        private Garagem origem;
        private Garagem destino;
        private int passageiros;
        private Veiculo veiculo;

        // Construtor
        public Viagem(Garagem origem, Garagem destino, int passageiros, Veiculo veiculo)
        {
            this.origem = origem;
            this.destino = destino;
            this.passageiros = passageiros;
            this.veiculo = veiculo;
        }

        // Métodos públicos
        public Garagem GetOrigem()
        {
            return origem;
        }

        public Garagem GetDestino()
        {
            return destino;
        }

        public int GetPassageiros()
        {
            return passageiros;
        }

        public Veiculo GetVeiculo()
        {
            return veiculo;
        }
    }
}