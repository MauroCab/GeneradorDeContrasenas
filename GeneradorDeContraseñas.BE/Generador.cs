using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeContraseñas.BE
{
    public class Generador
    {
        private const string CarMinusculas = "abcdefghijklmnopqrstuvwxyz";
        private const string CarMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string CarNumeros = "0123456789";
        private const string CarSimbolos = "!¡¿@#$%^&*()_-+=<>?";


        public string GenerarContraseña(int aLongitud,
                                        bool aMayusculas,
                                        bool aNumeros,
                                        bool aSimbolos)
        {
            StringBuilder contrasena = new StringBuilder();

            string caracteres = CarMinusculas;

            if (aMayusculas)
            {
                caracteres += CarMayusculas;
            }

            if (aNumeros)
            {
                caracteres += CarNumeros;
            }

            if (aSimbolos)
            {
                caracteres += CarSimbolos;
            }

            Random random = new Random();

            for (int i = 0; i < aLongitud; i++)
            {
                int indice = random.Next(caracteres.Length);
                contrasena.Append(caracteres[indice]);
            }

            return contrasena.ToString();

        }
    }
}
