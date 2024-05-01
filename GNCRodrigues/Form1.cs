using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GNCRodrigues
{
    public partial class Form1 : Form
    {
        private void ActualizarDataGridView()
        {
            try
            {
                // Abrir la conexión a la base de datos
                Conexion.Open();

                // Preparar la consulta SQL para obtener todos los registros de la tabla Orden
                string consulta = "SELECT * FROM Orden";
                SqlCommand comando = new SqlCommand(consulta, Conexion);

                // Crear un SqlDataAdapter para obtener los datos de la consulta
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                // Crear un DataTable para almacenar los datos de la consulta
                DataTable dt = new DataTable();

                // Llenar el DataTable con los datos obtenidos de la consulta
                adaptador.Fill(dt);

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView1 .DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                Conexion.Close();
            }
        }

        public SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-417K253;Initial Catalog=GNCRodrigues;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gNCRodriguesDataSet1.Orden' Puede moverla o quitarla según sea necesario.
            this.ordenTableAdapter.Fill(this.gNCRodriguesDataSet1.Orden);
            // TODO: esta línea de código carga datos en la tabla 'gNCRodriguesDataSet.Table' Puede moverla o quitarla según sea necesario.
            this.tableTableAdapter.Fill(this.gNCRodriguesDataSet.Table);

            CargarDatosDataGridView();

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();

            string consulta = "insert into Orden (Dominio, Vehiculo, Nafta, Fecha, Telefono, CortaCorriente, Detalles, Fallas, Presupuesto, ConfirmoCliente, TrabajoRealizado, AvisadoParaRetirar, Total) values (@Dominio, @Vehiculo, @Nafta, @Fecha, @Telefono, @CortaCorriente, @Detalles, @Fallas, @Presupuesto, @ConfirmoCliente, @TrabajoRealizado, @AvisadoParaRetirar, @Total) ";
            SqlCommand comando = new SqlCommand(consulta, Conexion);

            comando.Parameters.AddWithValue("@Dominio", Tb_dominio.Text);
            comando.Parameters.AddWithValue("@Vehiculo", Tb_Vehiculo.Text);
            comando.Parameters.AddWithValue("@Nafta", Cb_Nafta.Checked );
            comando.Parameters.AddWithValue("@Fecha", Dtp_Fecha.Value);
            comando.Parameters.AddWithValue("@Telefono", Tb_Telefono.Text);
            comando.Parameters.AddWithValue("@CortaCorriente",Cb_Cortacorriente.Checked);
            comando.Parameters.AddWithValue("@Detalles", Tb_Detalle.Text);
            comando.Parameters.AddWithValue("@Fallas",Tb_Fallas.Text);
            comando.Parameters.AddWithValue("@Presupuesto",Tb_presupuesto.Text);
            comando.Parameters.AddWithValue("@ConfirmoCliente",Cb_clienteavisado.Checked);
            comando.Parameters.AddWithValue("@TrabajoRealizado", Tb_Trabajo.Text);
            comando.Parameters.AddWithValue("@AvisadoParaRetirar", Cb_clienteavisado.Checked);    
            comando.Parameters.AddWithValue("@Total", Tb_total.Text);


                // Ejecutar la consulta SQL
                comando.ExecuteNonQuery();

                // Mostrar mensaje de éxito
                MessageBox.Show("Los datos se han guardado correctamente.");

                // Limpiar los TextBoxes después de guardar los datos
                LimpiarTextBoxes();
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                Conexion.Close();
            }

            

        }

        private void LimpiarTextBoxes()
        {
            // Limpiar el contenido de todos los TextBoxes

            Tb_Fallas.Clear();
            Tb_Trabajo.Clear() ;
            Tb_dominio.Clear();
            Tb_presupuesto.Clear();
            Tb_Detalle.Clear();
            Tb_Telefono.Clear();
            Tb_total.Clear();
            Tb_Vehiculo.Clear();
            Cb_clienteavisado.Checked = false;
            Cb_Cortacorriente.Checked = false;
            Cb_Nafta.Checked = false;
            Cb_retirar.Checked = false;
            Dtp_Fecha.Value= DateTime.Now;

        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {

                try
                {
                    Conexion.Open();

                    string consulta = "UPDATE Orden SET Vehiculo = @Vehiculo, Nafta = @Nafta, Fecha = @Fecha, Telefono = @Telefono, CortaCorriente = @CortaCorriente, Detalles = @Detalles, Fallas = @Fallas, Presupuesto = @Presupuesto, ConfirmoCliente = @ConfirmoCliente, TrabajoRealizado = @TrabajoRealizado, AvisadoParaRetirar = @AvisadoParaRetirar, Total = @Total WHERE Dominio = @Dominio";
                    SqlCommand comando = new SqlCommand(consulta, Conexion);

                    comando.Parameters.AddWithValue("@Vehiculo", Tb_Vehiculo.Text);
                    comando.Parameters.AddWithValue("@Nafta", Cb_Nafta.Checked);
                    comando.Parameters.AddWithValue("@Fecha", Dtp_Fecha.Value);
                    comando.Parameters.AddWithValue("@Telefono", Tb_Telefono.Text);
                    comando.Parameters.AddWithValue("@CortaCorriente", Cb_Cortacorriente.Checked);
                    comando.Parameters.AddWithValue("@Detalles", Tb_Detalle.Text);
                    comando.Parameters.AddWithValue("@Fallas", Tb_Fallas.Text);
                    comando.Parameters.AddWithValue("@Presupuesto", Tb_presupuesto.Text);
                    comando.Parameters.AddWithValue("@ConfirmoCliente", Cb_clienteavisado.Checked);
                    comando.Parameters.AddWithValue("@TrabajoRealizado", Tb_Trabajo.Text);
                    comando.Parameters.AddWithValue("@AvisadoParaRetirar", Cb_retirar.Checked);
                    comando.Parameters.AddWithValue("@Total", Tb_total.Text);
                    comando.Parameters.AddWithValue("@Dominio", Tb_dominio.Text);

                    // Ejecutar la consulta SQL
                    int filasActualizadas = comando.ExecuteNonQuery();

                    // Verificar si se actualizó algún registro
                    if (filasActualizadas > 0)
                    {
                        // Mostrar mensaje de éxito
                        MessageBox.Show("El registro se ha modificado correctamente.");
                    }
                    else
                    {
                        // Mostrar mensaje si no se actualizó ningún registro (puede ser porque el Dominio no existe)
                        MessageBox.Show("No se encontró ningún registro con el Dominio especificado.");
                    }
                ActualizarDataGridView();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión a la base de datos
                    Conexion.Close();
                }
            

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el Dominio del elemento seleccionado en la tabla
            string dominioSeleccionado = Tb_dominio.Text;

            // Verificar si se seleccionó un Dominio
            if (!string.IsNullOrEmpty(dominioSeleccionado))
            {
                try
                {
                    Conexion.Open();

                    // Preparar la consulta SQL para eliminar el registro con el Dominio especificado
                    string consulta = "DELETE FROM Orden WHERE Dominio = @Dominio";
                    SqlCommand comando = new SqlCommand(consulta, Conexion);
                    comando.Parameters.AddWithValue("@Dominio", dominioSeleccionado);

                    // Ejecutar la consulta SQL
                    int filasEliminadas = comando.ExecuteNonQuery();

                    // Verificar si se eliminó algún registro
                    if (filasEliminadas > 0)
                    {
                        // Mostrar mensaje de éxito
                        MessageBox.Show("El registro se ha eliminado correctamente.");
                    }
                    else
                    {
                        // Mostrar mensaje si no se eliminó ningún registro (puede ser porque el Dominio no existe)
                        MessageBox.Show("No se encontró ningún registro con el Dominio especificado.");
                    }
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión a la base de datos
                    Conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Dominio para eliminar el registro.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDatosDataGridView()
        {
            try
            {
                Conexion.Open();

                // Preparar la consulta SQL para obtener todos los registros de la tabla Orden
                string consulta = "SELECT * FROM Orden";
                SqlCommand comando = new SqlCommand(consulta, Conexion);

                // Crear un SqlDataAdapter para obtener los datos de la consulta
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                // Crear un DataTable para almacenar los datos de la consulta
                DataTable dt = new DataTable();

                // Llenar el DataTable con los datos obtenidos de la consulta
                adaptador.Fill(dt);

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en el DataGridView: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                Conexion.Close();
            }
        }


    }
}

