namespace PracticaLogin
{
    partial class PrimerProyecto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            txtTipo = new ComboBox();
            lblTipo = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 69);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(152, 148);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(283, 27);
            txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(59, 151);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(471, 229);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(157, 27);
            txtDocumento.TabIndex = 4;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(363, 232);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(486, 53);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(130, 59);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += Ingresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(486, 132);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 59);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTipo
            // 
            txtTipo.FormattingEnabled = true;
            txtTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            txtTipo.Location = new Point(152, 228);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(151, 28);
            txtTipo.TabIndex = 8;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(59, 235);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo";
            // 
            // PrimerProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 342);
            Controls.Add(lblTipo);
            Controls.Add(txtTipo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(lblDocumento);
            Controls.Add(txtDocumento);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrimerProyecto";
            Text = "Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private ComboBox txtTipo;
        private Label lblTipo;
    }
}