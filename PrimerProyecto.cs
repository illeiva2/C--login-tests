using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLogin
{
    public partial class PrimerProyecto : Form
    {
        public PrimerProyecto()
        {
            InitializeComponent();
        }
        public class Postulante
        {
            private string? nombre;
            private string? apellido;
            private string? tipo;
            private int documento;
            public Postulante(string? nombre, string? apellido, string? tipo, int documento)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Tipo = tipo;
                this.Documento = documento;
            }
            public string? Nombre { get { return nombre; } set { nombre = value; } }
            public string? Apellido { get { return apellido; } set { apellido = value; } }
            public int Documento { get { return documento; } set { documento = value; } }
            public string? Tipo { get { return tipo; } set { tipo = value; } }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string nom;
            string ape;
            int doc;
            string tip;
            nom = txtNombre.Text;
            ape = txtApellido.Text;
            doc = Convert.ToInt32(txtDocumento.Text);
            tip = txtTipo.Text;
            Postulante postulante1 = new Postulante(nom, ape, tip, doc);
            MessageBox.Show($"Nombre del postulante: {postulante1.Apellido}, {postulante1.Nombre} Documento: {postulante1.Documento}", "INGRESO DEL POSTULANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _ = txtApellido.Text == "";
            _ = txtDocumento.Text == "";
            _ = txtNombre.Text == "";
        }
    }
}
