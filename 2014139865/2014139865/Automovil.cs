using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865
{
    public class Automovil:Carro
    {
        TipoAuto _tipoAuto;




        public Automovil(Volante volante, Parabrisas parabrisas, int numAsientos, int numLlantas,
                         Propietario propietario, TipoCarro tipoCarro, TipoAuto tipoAuto) 
            : base(volante, parabrisas,numAsientos, numLlantas, propietario,tipoCarro)
        {
          /*  _tipoAuto = tipoAuto;
            _propietario = propietario;
            _volante = volante;
            _numLlantas = numLlantas;
            _tipoCarro = tipoCarro;
            */
        }


        /*      
         *      
         *      
         *      Propietario _propietario;
                Volante _volante;
                int _numLlantas=4, _numAsientos=5;
                TipoCarro _tipoCarro;
                */




        /*
        Carro(Volante volante, Parabrisas parabrisas,
            int numAsientos, int numLlantas, Propietario propietario,
            TipoCarro tipoCarro)
        {

            _volante = volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
            _tipocarro = tipoCarro;


        }






        

     */

    }
}



