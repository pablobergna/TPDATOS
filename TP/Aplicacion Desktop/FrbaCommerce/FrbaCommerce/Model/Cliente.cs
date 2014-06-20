using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{
    public class Cliente
    {
        public int ID { get; set; }
        public string cliNombre { get; set; }
        public string cliApellido { get; set; }
        public string cliTipoDoc { get; set; }
        public int cliDni { get; set; }
        public string cliEmail { get; set; }
        public int cliTelefono { get; set; }
        public string cliDireccion { get; set; }
        public string cliPiso { get; set; }
        public string cliDpto { get; set; }
        public string cliLocalidad { get; set; }
        public string cliCodPostal { get; set; }
        public DateTime cliFechaNac { get; set; }
    }
}