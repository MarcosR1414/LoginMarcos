using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace acceso
{
    public partial class Registro : Form
    {
        private SqlConnection sqlConnection;

        public Registro()
        {
            InitializeComponent();
            // Configura tu cadena de conexión aquí
            string connectionString = "Data Source=DESKTOP-R81UOB3;Initial Catalog=LoginForms;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén los valores ingresados por el usuario
                string nombreUsuario = User.Text;
                string correo = Correo.Text;
                string contraseña = Contraseña.Text;

                // Abre la conexión a la base de datos
                sqlConnection.Open();

                // Define la consulta SQL para insertar un nuevo usuario
                string query = "INSERT INTO Usuarios (Usuario, Correo, Contraseña) VALUES (@Usuario, @Correo, @Contraseña)";

                // Crea un objeto SqlCommand con la consulta y los parámetros
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Usuario", nombreUsuario);
                sqlCommand.Parameters.AddWithValue("@Correo", correo);
                sqlCommand.Parameters.AddWithValue("@Contraseña", contraseña);

                // Ejecuta la consulta para insertar el nuevo usuario
                sqlCommand.ExecuteNonQuery();

                // Cierra la conexión
                sqlConnection.Close();

                MessageBox.Show("Usuario registrado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el texto en el control User cambia

        }
        private void Contraseña_TextChanged(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el texto en el control Contraseña cambia
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();

            // Abrir o mostrar Form1.cs
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
