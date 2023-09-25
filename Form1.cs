using CapaPresentacion;
using System.Data.SqlClient;

namespace acceso
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-R81UOB3;Initial Catalog=LoginForms;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();

            // Muestra el formulario Registro
            registroForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1)
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obt�n los valores ingresados por el usuario
                string nombreUsuario = User.Text;
                string contrase�a = Contrase�a.Text;

                // Abre la conexi�n a la base de datos
                sqlConnection.Open();

                // Define la consulta SQL para seleccionar los registros que coinciden con el usuario y contrase�a
                string query = "SELECT * FROM Usuarios WHERE Usuario = @User AND Contrase�a = @Contrase�a";

                // Crea un objeto SqlCommand con la consulta y los par�metros
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@User", nombreUsuario);
                sqlCommand.Parameters.AddWithValue("@Contrase�a", contrase�a);

                // Ejecuta la consulta y obt�n un lector de datos
                SqlDataReader reader = sqlCommand.ExecuteReader();

                // Comprueba si se encontr� un registro en la base de datos
                if (reader.Read())
                {
                    // Se encontr� un registro, lo que significa que el usuario existe
                    MessageBox.Show("Usuario encontrado en la base de datos. Puede iniciar sesi�n.");

                    // Cierra el lector de datos
                    reader.Close();

                    // Cierra la conexi�n
                    sqlConnection.Close();

                    // Oculta el formulario actual
                    this.Hide();

                    // Abre el formulario de Editor
                    Editor editorForm = new Editor();
                    editorForm.ShowDialog(); // Usamos ShowDialog para bloquear el formulario anterior hasta que se cierre el Editor
                }
                else
                {
                    // No se encontr� un registro, lo que significa que el usuario no existe
                    MessageBox.Show("Usuario no encontrado en la base de datos. Verifique sus credenciales.");

                    // Cierra el lector de datos
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el usuario: " + ex.Message);
            }
            finally
            {
                // Cierra la conexi�n
                sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}