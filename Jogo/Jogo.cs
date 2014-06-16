using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    public class Jogo
    {
        private int limInferior;
        private int limSuperior;
        private int numeroSorteado;
        private int numMaxTentativas;
        private int numTentado;
        private int numTentativas;

        public Jogo(int limSuperior, int limInferior, int numMaxTentativas)
        {
            numeroSorteado = RandomNumber(1, 100);
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }        public String Ajuda(){
            if (numTentado > numeroSorteado)
            {
                return "maior";
            } else {
                return "menor";
            }
        }        public Boolean PodeJogar(){
            return (numTentativas < numMaxTentativas) ? true : false;
        }        public Boolean Tentativa(int numero){
            return (numero == numeroSorteado) ? true : false;
        }
    }
}
