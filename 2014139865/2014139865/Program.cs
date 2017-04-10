using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2014139865;

namespace _2014139865
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.Write("entrando a la ejecucion");

            var cantidad_automoviles = 4;
            var cantidad_buses = 2;


            /* automoviles 
             * 4 automoviles 
             * 4 llantas por cada automovil = 16 llantas 
             * 5 asientos para cada automovil = 20 asientos
             * agregarle el chasis a cada carro
             
             */

            var numeroserie1 = "123456";
            var metraje1 = 0;
            Cinturon cinturon = new Cinturon(numeroserie1,metraje1);
            Asiento asiento = new Asiento(cinturon, numeroserie1);
            Llanta llanta = new Llanta(numeroserie1);
            Volante volante = new Volante(numeroserie1);

            Parabrisas parabrisa = new Parabrisas(numeroserie1);
            string slctipoCarro = "automovil";

            TipoAuto tipoAuto = new TipoAuto();
            TipoCarro tipoCarro = new TipoCarro();// Enum.GetName(typeof(TipoCarro), slctipoCarro);
            String dni = "12345678";
            String nombres = "Gonza";
            String apellidos = "Sotelo Solari";
            String licencia = "primer nivel";

            Propietario propietario = new Propietario(dni, nombres, apellidos, licencia);
            Automovil car = new Automovil(volante, parabrisa,5, 4, propietario,tipoCarro,tipoAuto);



            var ensamblar = new Ensambladora();




            ensamblar.IniciarPersonalizacion(car, tipoCarro, "2005");
            ensamblar.Agregar(car);
    
            /////////////AUTOMOVIL 2
            var numeroserie2 = "789123";
            var metraje2 = 2;
            Cinturon cinturon2 = new Cinturon(numeroserie2, metraje2);
            Asiento asiento2 = new Asiento(cinturon2, numeroserie2);
            Llanta llanta2 = new Llanta(numeroserie2);
            Volante volante2 = new Volante(numeroserie2);

            Parabrisas parabrisa2 = new Parabrisas(numeroserie2);
            string slctipoCarro2 = "automovil";

            TipoAuto tipoAuto2 = new TipoAuto();
            TipoCarro tipoCarro2 = new TipoCarro();// Enum.GetName(typeof(TipoCarro), slctipoCarro);
            String dni2 = "72459448";
            String nombres2 = "Joe";
            String apellidos2 = "Garcia Plasencia";
            String licencia2 = "primer nivel";

            Propietario propietario2 = new Propietario(dni2, nombres2, apellidos2, licencia2);
            Automovil car2 = new Automovil(volante2, parabrisa2, 5, 4, propietario2, tipoCarro2, tipoAuto2);

            ensamblar.IniciarPersonalizacion(car, tipoCarro, "2160");
            ensamblar.Agregar(car2);
          
            //////AUTOMOVIL 3
            var numeroserie3 = "456789";
            var metraje3 = 3;
            Cinturon cinturon3 = new Cinturon(numeroserie3, metraje3);
            Asiento asiento3 = new Asiento(cinturon3, numeroserie3);
            Llanta llanta3 = new Llanta(numeroserie3);
            Volante volante3 = new Volante(numeroserie3);
            
            Parabrisas parabrisa3 = new Parabrisas(numeroserie3);
            string slctipoCarro3 = "automovil";

            TipoAuto tipoAuto3 = new TipoAuto();
            TipoCarro tipoCarro3 = new TipoCarro();// Enum.GetName(typeof(TipoCarro), slctipoCarro);
            String dni3 = "72459456";
            String nombres3 = "Cristiano Ronaldo ";
            String apellidos3 = "Dos Santos Aveiro";
            String licencia3 = "segundo nivel";

            Propietario propietario3 = new Propietario(dni3, nombres3, apellidos3, licencia3);
            Automovil car3 = new Automovil(volante3, parabrisa3, 5, 4, propietario3, tipoCarro3, tipoAuto3);

            ensamblar.IniciarPersonalizacion(car, tipoCarro, "1840");
            ensamblar.Agregar(car3);
          
            //////AUTOMOVIL 4

            var numeroserie4 = "234567";
            var metraje4 = 4;
            Cinturon cinturon4 = new Cinturon(numeroserie4, metraje4);
            Asiento asiento4 = new Asiento(cinturon4, numeroserie4);
            Llanta llanta4 = new Llanta(numeroserie4);
            Volante volante4 = new Volante(numeroserie4);

            Parabrisas parabrisa4 = new Parabrisas(numeroserie4);
            string slctipoCarro4 = "automovil";

            TipoAuto tipoAuto4 = new TipoAuto();
            TipoCarro tipoCarro4 = new TipoCarro();// Enum.GetName(typeof(TipoCarro), slctipoCarro);
            String dni4 = "72459466";
            String nombres4 = "Roger";
            String apellidos4 = "Federer";
            String licencia4 = "Tercer nivel";

            Propietario propietario4 = new Propietario(dni4, nombres4, apellidos4, licencia4);
            Automovil car4 = new Automovil(volante4, parabrisa4, 5, 4, propietario4, tipoCarro4, tipoAuto4);

            ensamblar.IniciarPersonalizacion(car, tipoCarro, "1630");
            ensamblar.Agregar(car4);
           
            //////BUS1
            var numeroserie5 = "234567";
            var metraje5 = 5;
            Cinturon cinturon5 = new Cinturon(numeroserie5, metraje5);
            Asiento asiento5 = new Asiento(cinturon5, numeroserie5);
            Llanta llanta5 = new Llanta(numeroserie5);
            Volante volante5 = new Volante(numeroserie5);

            Parabrisas parabrisa5 = new Parabrisas(numeroserie5);
            string slctipoCarro5 = "bus";

            TipoAuto tipoAuto5 = new TipoAuto();
            TipoCarro tipoCarro5 = new TipoCarro();// Enum.GetName(typeof(TipoCarro), slctipoCarro);
            String dni5 = "72459466";
            String nombres5 = "Rafael";
            String apellidos5 = "Nadal Parera";
            String licencia5 = "primer nivel";

            Propietario propietario5 = new Propietario(dni5, nombres5, apellidos5, licencia5);
            Automovil car5 = new Automovil(volante5, parabrisa5, 10, 6, propietario5, tipoCarro5, tipoAuto5);

            ensamblar.IniciarPersonalizacion(car, tipoCarro, "2965");
            ensamblar.Agregar(car5);
          
            ///////BUS2

            var numeroserie6 = "234567";
            var metraje6 = 6;
            Cinturon cinturon6 = new Cinturon(numeroserie6, metraje6);
            Asiento asiento6 = new Asiento(cinturon6, numeroserie6);
            Llanta llanta6 = new Llanta(numeroserie6);
            Volante volante6 = new Volante(numeroserie6);

            Parabrisas parabrisa6 = new Parabrisas(numeroserie6);
            string slctipoCarro6 = "bus";

            TipoAuto tipoAuto6 = new TipoAuto();
            TipoCarro tipoCarro6 = new TipoCarro();// Enum.GetName(typeof(TipoCarro), slctipoCarro);
            String dni6 = "724324567";
            String nombres6 = "Paolo";
            String apellidos6 = "Guerrero Gonzalez";
            String licencia6 = "segundo nivel";

            Propietario propietario6 = new Propietario(dni6, nombres6, apellidos6, licencia6);
            Automovil car6 = new Automovil(volante6, parabrisa6, 10, 6, propietario6, tipoCarro6, tipoAuto6);

            ensamblar.IniciarPersonalizacion(car, tipoCarro, "1997");
            ensamblar.Agregar(car6);


            ensamblar.FinalizarPersonalización();


        }
    }
}
