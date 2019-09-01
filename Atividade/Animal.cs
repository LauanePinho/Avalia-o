using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalição
{
    class Animal
    {
        public bool Vivo { get; protected set; }
        public float Idade { get; protected set; }
        public float Peso { get; protected set; }
        public string Som { get; protected set; }
        public float Velocidade { get; protected set; }

        public void Nasce()
        {
            Vivo = true;
            Idade = 0;
        }

        public void Cresce(float TempoDeVida)
        {
            Idade += TempoDeVida;
        }

        public Animal Reproduz()
        {
            Animal filho = new Animal();
            Filho.Nasce();
            return Filho;
        }

        public void Morre()
        {
            Vivo = False;
        }

        public virtual void Locomove()
        {
            Console.WriteLine("Move-se a uma velocidade de " + Velocidade + "KM/h");
        }

        public virtual void Comunica()
        {
            Console.WriteLine(Som);
        }
    }
}