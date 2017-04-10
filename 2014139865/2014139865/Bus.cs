using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865
{
    public class Bus : Carro
    {
        private static Volante volante;
        private static Parabrisas parabrisas;
        private static int numLlantas;
        private static Propietario propietario;
        private static TipoCarro tipoCarro;
        TipoBus _tipoBus;
        

       public  Bus(int numAsientos)
             : base(volante, parabrisas, numAsientos, numLlantas, propietario, tipoCarro)
        {

        }

        public TipoBus TipoBus
        {
            get { return _tipoBus; }
            set { _tipoBus = value; }
        }

}
}
