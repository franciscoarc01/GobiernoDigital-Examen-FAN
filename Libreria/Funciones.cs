using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public static class Funciones
    {
        public static string Decodificar (string renglon1, string renglon2, string renglon3)
        {
            for (uint numero = 0; numero < 10; numero++)
            {
                if (Matriz.MatrizNumero[Convert.ToByte(numero)][0] == renglon1 
                    && 
                    Matriz.MatrizNumero[Convert.ToByte(numero)][1] == renglon2
                    &&
                    Matriz.MatrizNumero[Convert.ToByte(numero)][2] == renglon3
                   )
                {
                    return numero.ToString();
                }
            }
            return "?";
        }

        private static Boolean checksum(uint suma) => suma % 11 == 0;

        public static String ValidacionCuenta(string cuenta)
        {
            uint suma = 0;
            int producto = 9;
            try
            {
                foreach (char numero in cuenta)
                {
                    suma += Convert.ToUInt32(Char.GetNumericValue(numero)) * Convert.ToUInt32(producto);
                    producto = producto - 1;
                }
                return string.Format("Cuenta: {0} {1}", cuenta, Funciones.checksum(suma));
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
