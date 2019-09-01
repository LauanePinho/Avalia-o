using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação
{
    class peixe : Animal
    {
        public void Barbatanas();
        {

        }

    public override void Locomove();
        {
            base.Locomove();
            Console.WriteLine("Os peixes nadam");
        }
    }
}
