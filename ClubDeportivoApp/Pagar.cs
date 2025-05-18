using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace ClubDeportivoApp
{
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                string query;
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();
                string tipoQuery = @"SELECT 'socio' AS tipo FROM Socio WHERE Dni = @dni 
                     UNION 
                     SELECT 'nosocio' AS tipo FROM NoSocios WHERE Dni = @dni";

                MySqlCommand tipoCmd = new MySqlCommand(tipoQuery, mySqlConnection);
                tipoCmd.Parameters.AddWithValue("@dni", txtDni.Text);

                object? result = tipoCmd.ExecuteScalar();
                string? tipo = result != null ? result.ToString() : null;

                if (tipo == null)
                {
                    MessageBox.Show("El cliente no está registrado como socio ni como no socio.");
                    return;
                }

                if (tipo == "socio")
                {
                   
                    query = @"SELECT c.Nombre, c.Apellido, soc.CodSocio, cuotMens.ValorMensual, cuotMens.TipoDePago, cuotMens.Vencimiento, cuotMens.CodCuotaMensual
                        FROM Clientes c INNER JOIN Socio soc ON c.Dni = soc.Dni INNER JOIN CuotaMensual cuotMens 
                        ON soc.CodSocio = cuotMens.CodSocio where c.Dni = @dni";
                }
                else if (tipo == "nosocio")
                {
                    query = @"SELECT c.Nombre, c.Apellido,noSoc.CodNoSocio, cuotDia.ValorFinal, cuotDia.TipoDePago, cuotDia.CodCuotaDiaria
                    FROM Clientes c inner join NoSocios noSoc ON c.Dni = noSoc.Dni inner join Actividades act 
                    ON noSoc.CodNoSocio = act.CodNoSocio inner join CuotaDiaria cuotDia ON cuotDia.CodCuota 
                    = act.CodCuotaDiaria where c.Dni = @dni";
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado como socio ni no socio.");
                    return;
                }

                MySqlCommand comando = new MySqlCommand(query, mySqlConnection);
                comando.Parameters.AddWithValue("@Dni", txtDni.Text);
                comando.CommandType = CommandType.Text;
                

                MySqlDataReader mySqlDataReader;
                mySqlDataReader = comando.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        lblResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        lblResApellido.Text = mySqlDataReader["Apellido"].ToString();
                        
                        if (tipo == "socio")
                        {
                            lblResCodCuota.Text = mySqlDataReader["CodCuotaMensual"].ToString();
                            lblResCod.Text = mySqlDataReader["CodSocio"].ToString();
                            lblResValor.Text = mySqlDataReader["ValorMensual"].ToString();
                            lblResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            lblResVencimiento.Text = mySqlDataReader["Vencimiento"].ToString();
                        }
                        else if (tipo == "nosocio")
                        {
                            lblResCodCuota.Text = mySqlDataReader["CodCuotaDiaria"].ToString();
                            lblResCod.Text = mySqlDataReader["CodNoSocio"].ToString();
                            lblResValor.Text = mySqlDataReader["ValorFinal"].ToString();
                            lblResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            lblResVencimiento.Text = "No posee.";
                        } 
                    }
                }
                else 
                {
                    MessageBox.Show("No se encontro el cliente.", "AVISO DEL SISTEMA", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
            finally 
            { 
                if(mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
