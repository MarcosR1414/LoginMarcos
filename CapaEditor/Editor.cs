using System;
using System.Windows.Forms;
using CapaDatos; // Asegúrate de tener una clase CN_Usuarios en tu capa de negocio

namespace CapaPresentacion
{
    public partial class Editor : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private bool Editar = false;

        public Editor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridView1.DataSource = objeto.MostrarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarUsuario(txtUsuario.Text, txtContraseña.Text, txtCorreo.Text);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarUsuarios();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex.Message);
                }
            }
            // EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarUsuario(txtUsuario.Text, txtContraseña.Text, txtCorreo.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarUsuarios();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void LimpiarForm()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
        }

        
    }

}
