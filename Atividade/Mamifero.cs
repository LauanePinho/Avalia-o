
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class Mamifero : Animal
    {
        public void Amamenta()
        {
            Console.WriteLine("Eles se amamentam");
        }

        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Os mamiferos podem andar e nadar");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("Os mamiferos tem diferentes formas de comnnunicão");
        }
    }
}
