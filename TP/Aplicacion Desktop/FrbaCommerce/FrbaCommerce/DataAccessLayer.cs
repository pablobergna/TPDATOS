using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using FrbaCommerce.Model;

namespace FrbaCommerce
{
    public class DataAccessLayer
    {
        #region Gets

        public Usuario getUser(Int32 user_id, Int32 rol_id)
        {
            Usuario result = new Usuario();
            using (SqlConnection connection = new SqlConnection( ConfigurationManager.ConnectionStrings["GD2013"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                //verificar la tabla que corresponde Y SELECT
                command.CommandText = @"select ROLES from ESQ.rol_usuario ru where ";
                command.Parameters.Add("@rol_id", SqlDbType.Int);
                command.Parameters.Add("@user_id", SqlDbType.Int);

                command.Parameters["@rol_id"].Value = rol_id;
                command.Parameters["@user_id"].Value = user_id;
                SqlDataReader Reg = command.ExecuteReader();

                if (Reg.Read())
                {
                    int cod;
                    int cod_sub;

                    if (!Reg.IsDBNull(0))  {
                        cod = Reg.GetInt32(0); ;
                    } else{
                        cod = -1;
                    }
                                        
                    if (!Reg.IsDBNull(1)){
                        cod_sub = Reg.GetInt32(1);
                    }else{
                        cod_sub = -1;
                    }

                    result = new Usuario() { id = user_id, rol = rol_id, user_rel = cod, user_rel_sub = cod_sub };
                }
            }
            return result;
        }

        #endregion




        # region Login

        public QueryResult BuscarUsuario(string user, string password)
        {
            QueryResult Resultado;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GD1C2014"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                //verificar la tabla correcta Y el select
                command.CommandText = @"select  from ESQ.usuario where USER=@user and PASSWORD = @password";
                
                command.Parameters.Add("@user", SqlDbType.NVarChar);
                command.Parameters.Add("@password", SqlDbType.NVarChar);
                
                command.Parameters["@user"].Value = user;
                command.Parameters["@password"].Value = password;
                
                SqlDataReader Reg = command.ExecuteReader();
                if (Reg.Read())
                {
                    if (Convert.ToInt32(Reg[1]) < 3)
                    {
                        Resultado = new QueryResult() { correct = true, ID = Convert.ToInt32(Reg[0]), mensaje = "Bienvenido Datos correctos" };

                        QueryResult salida = resetLogin(Convert.ToInt32(Reg[0]));

                        if (salida.correct == false)
                        {
                            Resultado.correct = salida.correct;
                            Resultado.mensaje = Resultado.mensaje + '\n' + salida.mensaje;
                        }
                    }
                    else
                    {
                        Resultado = new QueryResult() { correct = false, mensaje = "Usuario Inhabilitado" };
                    }
                }
                else
                {
                    Resultado = new QueryResult() { correct = false, mensaje = "Usuario/Contraseña invalidos" };

                    if (Reg.HasRows)
                    {
                        QueryResult salida = failLogin(Convert.ToInt32(Reg[1]));

                        if (salida.correct == false)
                        {
                            Resultado.mensaje = Resultado.mensaje + '\n' + salida.mensaje;
                        }
                    }
                }

            }
            return Resultado;
        }

        private QueryResult resetLogin(Int32 user_id)
        {
            QueryResult Resultado = new QueryResult();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GD2013"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                //Realizar el update 
                command.CommandText = @"update tabla
                                       set campo=0
                                           where usuario=@user_id";

                command.Parameters.Add("@userId", SqlDbType.Int);
                command.Parameters["@userId"].Value = user_id;

                Int32 Reg = command.ExecuteNonQuery();
                if (Reg > 0) {
                    Resultado.correct = true;
                } else {
                    Resultado.correct = false;
                    Resultado.mensaje = "No se puedo resetear los login's del usuario";
                }

            }
            return Resultado;
        }
        private QueryResult failLogin(Int32 user_id)
        {
            QueryResult Resultado = new QueryResult();


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GD2013"].ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"update GESTIONAR.usuario
                                       set usua_logins=usua_logins+1
                                           where usua_id= @user_id";

                command.Parameters.Add("@user_id", SqlDbType.Int);

                command.Parameters["@user_id"].Value = user_id;

                Int32 Reg = command.ExecuteNonQuery();
                if (Reg > 0)
                {
                    Resultado.correct = true;
                }
                else
                {
                    Resultado.correct = false;
                    Resultado.mensaje = "No se puedo actualizar los login's del usuario";
                }

            }
            return Resultado;
        }
        #endregion
    }
}