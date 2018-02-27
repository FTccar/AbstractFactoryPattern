using Data.Model.Abstract;
using Data.Model.Abstract.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainApp
{
    class FactoryController
    {
        private IArabaKasasi ArabaKasasi;
        private IArabaLastigi ArabaLastigi;

        public FactoryController(IArabaFabrikasi araba)
        {
            ArabaKasasi = araba.KasaUret();
            ArabaLastigi = araba.LastikUret();
        }

        public void LastikTak()
        {
            ArabaKasasi.LastikTak(ArabaLastigi);
        }
    }
}
