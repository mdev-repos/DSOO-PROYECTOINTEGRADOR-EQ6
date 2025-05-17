
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

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "CONTRASE�A")
            {
                txtContrase�a.Text = "";
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A";
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            // logica de lectura en BBDD

            //if true
                //Limpia datos ingresados
            txtUsuario.Text = "";
            txtContrase�a.Text = "";

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
