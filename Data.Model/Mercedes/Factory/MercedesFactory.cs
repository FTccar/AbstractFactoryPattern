using Data.Model.Abstract;
using Data.Model.Abstract.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Mercedes.Factory
{
    public class MercedesFactory : IArabaFabrikasi
    {
        public override IArabaKasasi KasaUret()
        {
            return new MercedesE200();
        }

        public override IArabaLastigi LastikUret()
        {
            return new MercedesLastik();
        }
    }
}
