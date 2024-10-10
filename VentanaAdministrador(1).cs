using System;
using System.Windows.Forms;

namespace ENE
{
    public partial class VentanaAdministrador : Form
    {
        private Label lblRutEmpleado;

        // Declaración de los campos de entrada
        private TextBox txtRutEmpleado;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblValorHora;
        private TextBox txtValorHora;
        private Label lblValorExtra;
        private TextBox txtValorExtra;
        private Button btnAgregarEmpleado;

        public VentanaAdministrador()
        {
            InitializeComponent();
        }

        private void VentanaAdministrador_Load(object sender, EventArgs e)
        {
            // Carga inicial de la ventana del Administrador
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Aquí puedes obtener los valores de los campos de entrada
            string rutEmpleado = txtRutEmpleado.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            decimal valorHora = decimal.Parse(txtValorHora.Text);
            decimal valorExtra = decimal.Parse(txtValorExtra.Text);

            // Luego puedes realizar operaciones con esta información, como agregar un empleado a una lista o una base de datos
            // Por ejemplo, puedes crear una clase Empleado y agregar una instancia de ella a una lista de empleados.

            // Después de agregar el empleado, puedes limpiar los campos de entrada o mostrar un mensaje de confirmación.
            LimpiarCampos();
            MessageBox.Show("Empleado agregado con éxito.");
        }

        private void LimpiarCampos()
        {
            // Limpia los campos de entrada
            txtRutEmpleado.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtValorHora.Clear();
            txtValorExtra.Clear();
        }
    }
}

