
using System.Windows.Forms;

namespace ENE
{
    partial class VentanaUsuarioNormal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblRutEmpleado;
        private TextBox txtRutEmpleado;
        private Label lblHorasTrabajadas;
        private TextBox txtHorasTrabajadas;
        private Label lblHorasExtras;
        private TextBox txtHorasExtras;
        private Label lblAFP;
        private ComboBox cmbAFP;
        private Label lblSalud;
        private ComboBox cmbSalud;
        private Button btnCalcularSueldo;
        private Label lblSueldoBruto;
        private Label lblDescuentoAFP;
        private Label lblDescuentoSalud;
        private Label lblSueldoLiquido;

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
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.cmbAFP = new System.Windows.Forms.ComboBox();
            this.cmbSalud = new System.Windows.Forms.ComboBox();
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.lblDescuentoAFP = new System.Windows.Forms.Label();
            this.lblDescuentoSalud = new System.Windows.Forms.Label();
            this.lblSueldoLiquido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(12, 280);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(100, 30);
            this.btnCalcularSueldo.TabIndex = 0;
            this.btnCalcularSueldo.Text = "Calcular Sueldo";
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(118, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(224, 280);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(330, 280);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 30);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(190, 12);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(240, 20);
            this.txtHorasTrabajadas.TabIndex = 4;
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(190, 48);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(240, 20);
            this.txtHorasExtras.TabIndex = 5;
            // 
            // cmbAFP
            // 
            this.cmbAFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFP.FormattingEnabled = true;
            this.cmbAFP.Items.AddRange(new object[] {
            "CUPRUM",
            "MODELO",
            "CAPITAL",
            "PROVIDA"});
            this.cmbAFP.Location = new System.Drawing.Point(190, 84);
            this.cmbAFP.Name = "cmbAFP";
            this.cmbAFP.Size = new System.Drawing.Size(240, 21);
            this.cmbAFP.TabIndex = 6;
            // 
            // cmbSalud
            // 
            this.cmbSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalud.FormattingEnabled = true;
            this.cmbSalud.Items.AddRange(new object[] {
            "FONASA",
            "CONSALUD",
            "MASVIDA",
            "BANMEDICA"});
            this.cmbSalud.Location = new System.Drawing.Point(190, 120);
            this.cmbSalud.Name = "cmbSalud";
            this.cmbSalud.Size = new System.Drawing.Size(240, 21);
            this.cmbSalud.TabIndex = 7;
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(12, 15);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(163, 13);
            this.lblHorasTrabajadas.TabIndex = 8;
            this.lblHorasTrabajadas.Text = "Horas Trabajadas (ejemplo: 160):";
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Location = new System.Drawing.Point(12, 51);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(133, 13);
            this.lblHorasExtras.TabIndex = 9;
            this.lblHorasExtras.Text = "Horas Extras (ejemplo: 10):";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Location = new System.Drawing.Point(12, 87);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(113, 13);
            this.lblAFP.TabIndex = 10;
            this.lblAFP.Text = "AFP (Seleccione una):";
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Location = new System.Drawing.Point(12, 123);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(120, 13);
            this.lblSalud.TabIndex = 11;
            this.lblSalud.Text = "Salud (Seleccione una):";
            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(103, 165);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(0, 13);
            this.lblSueldoBruto.TabIndex = 12;
            // 
            // lblDescuentoAFP
            // 
            this.lblDescuentoAFP.AutoSize = true;
            this.lblDescuentoAFP.Location = new System.Drawing.Point(103, 190);
            this.lblDescuentoAFP.Name = "lblDescuentoAFP";
            this.lblDescuentoAFP.Size = new System.Drawing.Size(0, 13);
            this.lblDescuentoAFP.TabIndex = 13;
            // 
            // lblDescuentoSalud
            // 
            this.lblDescuentoSalud.AutoSize = true;
            this.lblDescuentoSalud.Location = new System.Drawing.Point(103, 215);
            this.lblDescuentoSalud.Name = "lblDescuentoSalud";
            this.lblDescuentoSalud.Size = new System.Drawing.Size(0, 13);
            this.lblDescuentoSalud.TabIndex = 14;
            // 
            // lblSueldoLiquido
            // 
            this.lblSueldoLiquido.AutoSize = true;
            this.lblSueldoLiquido.Location = new System.Drawing.Point(103, 240);
            this.lblSueldoLiquido.Name = "lblSueldoLiquido";
            this.lblSueldoLiquido.Size = new System.Drawing.Size(0, 13);
            this.lblSueldoLiquido.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sueldo Bruto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descuento AFP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descuento Salud:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sueldo Líquido:";
            // 
            // VentanaUsuarioNormal
            // 
            this.ClientSize = new System.Drawing.Size(462, 332);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.cmbAFP);
            this.Controls.Add(this.cmbSalud);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblSalud);
            this.Controls.Add(this.lblSueldoBruto);
            this.Controls.Add(this.lblDescuentoAFP);
            this.Controls.Add(this.lblDescuentoSalud);
            this.Controls.Add(this.lblSueldoLiquido);
            this.Name = "VentanaUsuarioNormal";
            this.Text = "Calculadora de Sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnListar;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
    }
}
