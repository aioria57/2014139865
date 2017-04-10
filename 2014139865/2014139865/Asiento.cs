using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865
{
    public class Asiento
    {
         Cinturon _cinturon;
        string _numSerie;

        public Asiento(Cinturon cintu , string numSerie)
        {

            _cinturon = cintu;
            _numSerie = numSerie;
        }

    }
}
