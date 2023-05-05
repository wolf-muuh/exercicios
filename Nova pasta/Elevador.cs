using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta
{
    public class Elevador
    {
        public int qntPessoas;
        public int Capacidade { get; set; }

        public int Andar { get; set; }
        public int PosicaoAndar { get; set; }

        public void Inicializa(int capacidade, int andar)
        {
            Console.WriteLine($"A capacidade do elevador é de {capacidade} pessoas e o prédio tem {andar} andares");

        }

        public void Entrar()
        {
            qntPessoas = qntPessoas++;
        }

        public void Sair()
        {
            qntPessoas = qntPessoas--;
        }

        public void Subir()
        {
            Andar = Andar++;
        }

        public void Descer()
        {
            Andar = Andar--;
        }
    }
}