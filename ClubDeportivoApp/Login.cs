
namespace ClubDeportivoApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            // logica de lectura en BBDD

            //if true
                //Limpia datos ingresados
            txtUsuario.Text = "";
            txtContraseña.Text = "";

                //Abre form principal
            Form opcionesWdw = new Opciones();
            opcionesWdw.ShowDialog();

            //if false
                //Mostrar modal de Usuario y/o Contrasena incorrecta

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 400);
        }
    }
} 
