using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

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
                query = @"SELECT c.Nombre, c.Apellido, cuotMens.ValorMensual, cuotMens.TipoDePago, cuotMens.Vencimiento
                    FROM Clientes c INNER JOIN Socio soc ON c.Dni = soc.Dni INNER JOIN CuotaMensual cuotMens 
                    ON soc.CodSocio = cuotMens.CodSocio where c.Dni = @dni";

                query = @"SELECT c.Nombre, c.Apellido, cuotDia.ValorFinal, cuotDia.TipoDePago
                    FROM Clientes c inner join NoSocios noSoc ON c.Dni = noSoc.Dni inner join Actividades act 
                    ON noSoc.CodNoSocio = act.CodNoSocio inner join CuotaDiaria cuotDia ON cuotDia.CodCuotDiaria 
                    = act.CodCuotaDiaria where c.Dni = @dni";
                MySqlCommand comando = new MySqlCommand(query, mySqlConnection);
                comando.Parameters.AddWithValue("@Dni", txtDni.Text);
                comando.CommandType = CommandType.Text;
                mySqlConnection.Open();

                MySqlDataReader mySqlDataReader;
                mySqlDataReader = comando.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        lblResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        lblResApellido.Text = mySqlDataReader["Apellido"].ToString();
                        lblResValor.Text = mySqlDataReader["Valor"].ToString();
                        lblResVencimiento.Text = mySqlDataReader["Vencimiento"].ToString();
                        lblResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
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
