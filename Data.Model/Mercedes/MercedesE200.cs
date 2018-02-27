using Data.Model.Abstract;
using Data.Model.Abstract.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Mercedes
{
    class MercedesE200 : IArabaKasasi
    {
        public override void LastikTak(IArabaLastigi a)
        {
            Console.WriteLine("Lastik :"+a);
        }
    }
}
