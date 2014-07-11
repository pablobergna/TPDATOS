using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.DTO
{
    class RolDTO
    {
        private int id_rol;
        private string nombre_rol;

        public int idRol {
            get { return id_rol; }
            set { id_rol = value;}
        }

        public string descRol
        {
            get { return nombre_rol; }
            set { nombre_rol = value; }
        }

        public RolDTO(int id, string nombre){
            id_rol = id;
            nombre_rol = nombre;
        }

        public string ToString()
        {
            return nombre_rol;
        }

    }
}
