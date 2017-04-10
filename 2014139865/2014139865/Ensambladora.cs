using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2014139865
{
    public class Ensambladora{

        List<Carro> _Carro;

        


        public void Agregar(Carro carro){

            _Carro.Add(carro);

        }
        public void Eliminar(Carro carro){
            _Carro.Remove(carro);
        }
        public bool IniciarPersonalizacion(Carro carro,TipoCarro tp,String idChasis)
        {
            carro.NumSerieChasis = tp +"" +idChasis;
           
                
                return true;
        }

        public bool FinalizarPersonalización()
        {

            foreach (Carro itemB in _Carro)
            {
                Console.WriteLine(_Carro);

            }



            return true;
        }

        public Carro EmsamblarCarro(TipoCarro tipoCarro,TipoAuto tipAuto,TipoBus tipBus)
        {
            return null;
        }
    }
}
