using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaAdivinha
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
            this.numeroSorteado = RandomNumber(limInferior, limSuperior);
            this.numMaxTentativas = numMaxTentativas;
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

        public int LimInferior{
            set
            {
                this.limInferior = value;
            }
            get
            {
                return limInferior;
            }
        }
        public int LimSuperior
        {
            set
            {
                this.limSuperior = value;
            }
            get
            {
                return limSuperior;
            }
        }
        public int NumMaxTentativas
        {
            set
            {
                this.numMaxTentativas = value;
            }
            get
            {
                return numMaxTentativas;
            }
        }
        public int NumTentado
        {
            set
            {
                this.numTentado = value;
            }
            get
            {
                return numTentado;
            }
        }
        public int NumTentativas
        {
            set
            {
                this.numTentativas = value;
            }
            get
            {
                return numTentativas;
            }
        }
    }
}
