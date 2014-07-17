using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{
    public class Publicacion
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string descripcion { get; set; }
        public int tipo_publicacion { get; set; }
        public int stock { get; set; }
        public float precio { get; set; }
        public int visibilidad { get; set; }
        public int permitir_preguntas { get; set; }
        public DateTime vencimiento { get; set; }
        public string estado { get; set; }
        public Queue<int> rubros { get; set; }
    }
}
