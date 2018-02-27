using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Abstract.Factory
{
    public abstract class IArabaFabrikasi
    {
        abstract public IArabaKasasi KasaUret();
        abstract public IArabaLastigi LastikUret();
    }
}
