
namespace ENE
{
    partial class VentanaAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRutEmpleado = new System.Windows.Forms.Label();
            this.txtRutEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.lblValorExtra = new System.Windows.Forms.Label();
            this.txtValorExtra = new System.Windows.Forms.TextBox();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblRutEmpleado
            this.lblRutEmpleado.Location = new System.Drawing.Point(50, 30);
            this.lblRutEmpleado.Size = new System.Drawing.Size(100, 20);
            this.lblRutEmpleado.Text = "Rut Empleado:";

            // txtRutEmpleado
            this.txtRutEmpleado.Location = new System.Drawing.Point(160, 30);
            this.txtRutEmpleado.Size = new System.Drawing.Size(200, 20);

            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(50, 60);
            this.lblNombre.Size = new System.Drawing.Size(100, 20);
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(160, 60);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);

            // lblDireccion
            this.lblDireccion.Location = new System.Drawing.Point(50, 90);
            this.lblDireccion.Size = new System.Drawing.Size(100, 20);
            this.lblDireccion.Text = "Dirección:";

            // txtDireccion
            this.txtDireccion.Location = new System.Drawing.Point(160, 90);
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);

            // lblTelefono
            this.lblTelefono.Location = new System.Drawing.Point(50, 120);
            this.lblTelefono.Size = new System.Drawing.Size(100, 20);
            this.lblTelefono.Text = "Teléfono:";

            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(160, 120);
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);

            // lblValorHora
            this.lblValorHora.Location = new System.Drawing.Point(50, 150);
            this.lblValorHora.Size = new System.Drawing.Size(100, 20);
            this.lblValorHora.Text = "Valor Hora:";

            // txtValorHora
            this.txtValorHora.Location = new System.Drawing.Point(160, 150);
            this.txtValorHora.Size = new System.Drawing.Size(200, 20);

            // lblValorExtra
            this.lblValorExtra.Location = new System.Drawing.Point(50, 180);
            this.lblValorExtra.Size = new System.Drawing.Size(100, 20);
            this.lblValorExtra.Text = "Valor Extra:";

            // txtValorExtra
            this.txtValorExtra.Location = new System.Drawing.Point(160, 180);
            this.txtValorExtra.Size = new System.Drawing.Size(200, 20);

            // btnAgregarEmpleado
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(160, 220);
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);

            // VentanaAdministrador
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.txtValorExtra);
            this.Controls.Add(this.lblValorExtra);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRutEmpleado);
            this.Controls.Add(this.lblRutEmpleado);
            this.Name = "VentanaAdministrador";
            this.Text = "Administrador - Ingreso de Empleados";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
