using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class Ave : Animal
    {
        public void Migra()
        {
            Console.WriteLine("As aves migram quando necessario");
        }

        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Ave voa");
        }
        public override void Comunica();
        {
            base.Comunica();
            Console.WriteLine("As aves cantam quando necessario");
        }

    }
}
