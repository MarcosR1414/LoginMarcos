using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CN_Usuarios
    {
        private string cadenaConexion = "Data Source=DESKTOP-R81UOB3;Initial Catalog=LoginForms;Integrated Security=True"; // Reemplaza con tu cadena de conexión

        public DataTable MostrarUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();

                try
                {
                    conexion.Open();
                    adapter.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }

                return tabla;
            }
        }

        public void InsertarUsuario(string usuario, string contraseña, string correo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "INSERT INTO Usuarios (Usuario, Contraseña, Correo) VALUES (@Usuario, @Contraseña, @Correo)";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@Correo", correo);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void EditarUsuario(string usuario, string contraseña, string correo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "UPDATE Usuarios SET Usuario = @Usuario, Contraseña = @Contraseña, Correo = @Correo WHERE Num = @Num";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@Correo", correo);
                

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        
    }
}
