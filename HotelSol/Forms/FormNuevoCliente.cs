using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelSol.Forms
{
    partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
            bGuardar.Click += bGuardar_Click; // Asociar el evento Click del botón bGuardar al método bGuardar_Click
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            int idCliente = int.Parse(tbIDclient.Text);
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string direccion = tbDireccion.Text;
            string poblacion = tbPoblación.Text;
            string CP = tbCP.Text;
            string telefono = tbTelefono.Text;
            string email = tbemail.Text;

            // Cadena de conexión para conectarse a la base de datos local
            string connectionString = "Data Source=34.175.211.115;Initial Catalog=travellershotelsolBD;Persist Security Info=True;User ID=sqlserver;Password=travellersERP13;";

            try
            {
                // Crear una conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para insertar un nuevo cliente
                    string insertQuery = "INSERT INTO Clientes (idCliente, nombre, apellidos, direccion, poblacion, CP, telefono, email) " +
                                         "VALUES (@idCliente, @nombre, @apellidos, @direccion, @poblacion, @CP, @telefono, @email)";

                    // Crear un comando SQL con la consulta y la conexión
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Agregar parámetros a la consulta
                        command.Parameters.AddWithValue("@idCliente", idCliente);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@direccion", direccion);
                        command.Parameters.AddWithValue("@poblacion", poblacion);
                        command.Parameters.AddWithValue("@CP", CP);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@email", email);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Comprobar si se insertó el cliente correctamente
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente guardado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar el cliente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
