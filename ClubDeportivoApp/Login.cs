using System.Windows.Forms.VisualStyles;
using ClubDeportivoApp.Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClubDeportivoApp
{
    public partial class Login : Form
    {

        public bool Autenticado { get; private set; }
        public string UsuarioActual { get; private set; }
        public string RolUsuario { get; private set; }

        public Login()
        {
            InitializeComponent();
            Autenticado = false;

            Usuario usuarioDatos = new Usuario();
            usuarioDatos.InicializarUsuarioAdmin();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuarioDatos = new Usuario();
            if (usuarioDatos.ValidarUsuario(usuario, contrasenia))
            {
                var usu = usuarioDatos.ObtenerUsuarioPorUsername(usuario);
                if (usu != null && usu.Activo)
                {
                    Autenticado = true;
                    UsuarioActual = usu.Username;
                    RolUsuario = usu.Rol;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario inactivo", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {

        }



        private void Login_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 400);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
} 
