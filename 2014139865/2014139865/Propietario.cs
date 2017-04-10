using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139865
{
    public class Propietario
    {
        String DNI;
        String Nombre;
        String Apellido;
        String LicenciaConducir;

        public Propietario(String dni,String nombre,String apellido,String licenciaconducir)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            LicenciaConducir = licenciaconducir;
        }

      

    }
}
