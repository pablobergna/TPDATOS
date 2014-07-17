using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Tools
{
    class Validacion
    {

        public static int validarCUIT(string cuit)
        {

            string[] vecCUIL = cuit.Split('-');

            if (vecCUIL.Length != 3)
            {
                return -1;
            }
            else if (vecCUIL[0].Length != 2 || vecCUIL[2].Length != 1)
            {
                return -1;
            }
            return 0;
        }
    }
}
