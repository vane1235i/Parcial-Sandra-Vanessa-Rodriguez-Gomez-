using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PARCIAL2._0
{
    public partial class Form1 : Form
    {

        string cadenaConexion =
    @"Server=localhost;Database=Productos;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
            ProbarConexion();
        }

        private void ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion =
                       new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    MessageBox.Show(
                        "¡Conexión exitosa con SQL Server!"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de conexión: " + ex.Message
                );
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion =
                       new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta =
                        "SELECT IdProducto, Nombre, Categoria, Precio, Existencias FROM Productos";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dataGridView1.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar productos: " + ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
////////////////////////////////////////////////////////////////////////////////////////////
/// Participantes: /// - Sandra Vanessa Rodriguez Gomez, Sergio Steven Palacios Lopez.
////////////////////////////////////////////////////////////////////////////////////////////