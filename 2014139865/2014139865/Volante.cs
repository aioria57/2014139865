using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865
{
    public class Volante
    {

        String _numSerie;

        
        public Volante(String numserie)
        {

            _numSerie = numserie;
        }

        public String NumeroSerie { get { return _numSerie; } }
        
    }
}
