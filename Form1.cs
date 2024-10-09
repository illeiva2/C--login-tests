using Org.BouncyCastle.Pqc.Crypto.Lms;
using PracticaLogin.Datos;
using System.Data;

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
            DataTable tablaLogin = new(); 
            Datos.Usuarios dato = new();
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtContra.Text);
            if (tablaLogin.Rows.Count > 0)
            {
            MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}
