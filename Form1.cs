namespace PracticaLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = string.Empty;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = string.Empty;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if  (txtUsuario.Text == "Administrador" && txtContra.Text == "Admin1234")
            {
                PrimerProyecto primerproyecto = new PrimerProyecto();
                primerproyecto.Show();
                this.Hide();
            }
        }
    }
}
