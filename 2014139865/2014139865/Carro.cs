using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865
{
    public abstract class Carro
    {
        private  String _numSerieMotor;
        private  String _numSerieChasis;

        Volante _volante;
        Parabrisas _parabrisas;
        Llanta _llanta;
        Asiento _asiento;
        Propietario _propietario;
        TipoCarro _tipocarro;

        public Carro()
        {

        }

        public Carro(Volante volante, Parabrisas parabrisas,
             int numAsientos, int numLlantas, Propietario propietario,
             TipoCarro tipoCarro)
        {

            _volante = volante;
            _parabrisas = parabrisas;
            _propietario = propietario;
            _tipocarro = tipoCarro;


        }


        public String NumSerieChasis
        {
            get
            {
                return NumSerieChasis;
            }
            set {

               NumSerieChasis = value;

            }


        }


        public String NumSerieMotor
        {
            get
            {
                return NumSerieMotor;
            }
            set
            {
                 NumSerieMotor = value;
            }

        }



        
    }
}
