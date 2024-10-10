using System;
using System.Windows.Forms;
using System.IO;

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

            // Crear una cadena de texto con la información del empleado
            string empleadoInfo = $"{rutEmpleado} | {nombre} | {direccion} | {telefono} | {valorHora} | {valorExtra}";

            // Especifica la ubicación del archivo donde deseas guardar la información
            string filePath = "informacion_empleado.txt";

            // Escribe la información en el archivo de texto
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(empleadoInfo);
            }

            // Luego puedes realizar operaciones adicionales, como agregar el empleado a una lista o base de datos

            // Después de agregar el empleado, puedes limpiar los campos de entrada o mostrar un mensaje de confirmación
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

