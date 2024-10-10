using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ENE
{
    public partial class VentanaUsuarioNormal : Form
    {
        private bool sueldoCalculado;

        public VentanaUsuarioNormal()
        {
            InitializeComponent();
        }

        private void VentanaUsuarioNormal_Load(object sender, EventArgs e)
        {
            // Carga inicial de la ventana de Usuario Normal
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            // Después de calcular el sueldo, establece la variable sueldoCalculado en true.
            sueldoCalculado = true;

            // Muestra un mensaje de éxito
            MessageBox.Show("El sueldo se ha calculado con éxito.", "Cálculo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Obtener valores ingresados por el usuario
            decimal horasTrabajadas = decimal.Parse(txtHorasTrabajadas.Text, CultureInfo.InvariantCulture);
            decimal horasExtras = decimal.Parse(txtHorasExtras.Text, CultureInfo.InvariantCulture);

            // Calcular sueldo bruto
            decimal valorHora = 5000;
            decimal valorHoraExtra = 7000;
            decimal sueldoBruto = (horasTrabajadas * valorHora) + (horasExtras * valorHoraExtra);

            // Calcular descuento AFP
            decimal descuentoAFP = 0;
            string afpSeleccionada = cmbAFP.SelectedItem.ToString();
            switch (afpSeleccionada)
            {
                case "CUPRUM":
                    descuentoAFP = sueldoBruto * 0.07m;
                    break;
                case "MODELO":
                    descuentoAFP = sueldoBruto * 0.09m;
                    break;
                case "CAPITAL":
                    descuentoAFP = sueldoBruto * 0.12m;
                    break;
                case "PROVIDA":
                    descuentoAFP = sueldoBruto * 0.13m;
                    break;
                default:
                    // Manejar el caso si no se selecciona ninguna AFP
                    break;
            }

            // Calcular descuento de salud
            decimal descuentoSalud = 0;
            string saludSeleccionada = cmbSalud.SelectedItem.ToString();
            switch (saludSeleccionada)
            {
                case "FONASA":
                    descuentoSalud = sueldoBruto * 0.12m;
                    break;
                case "CONSALUD":
                    descuentoSalud = sueldoBruto * 0.13m;
                    break;
                case "MASVIDA":
                    descuentoSalud = sueldoBruto * 0.14m;
                    break;
                case "BANMEDICA":
                    descuentoSalud = sueldoBruto * 0.15m;
                    break;
                default:
                    // Manejar el caso si no se selecciona ninguna AFP
                    break;
            }

            // Calcular sueldo líquido
            decimal sueldoLiquido = sueldoBruto - descuentoAFP - descuentoSalud;

            // Cambiar la configuración regional para mostrar el símbolo de peso
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-CL");

            // Mostrar los resultados en etiquetas o MessageBox
            lblSueldoBruto.Text = sueldoBruto.ToString("C");
            lblDescuentoAFP.Text = descuentoAFP.ToString("C");
            lblDescuentoSalud.Text = descuentoSalud.ToString("C");
            lblSueldoLiquido.Text = sueldoLiquido.ToString("C");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (sueldoCalculado)
            {
                // Agrega aquí la lógica para guardar los datos si es necesario.
                // Mostrar un mensaje de éxito después de guardar.
                MessageBox.Show("Los datos se han guardado con éxito.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Muestra un mensaje de error si se intenta guardar sin calcular el sueldo primero.
                MessageBox.Show("Debes calcular el sueldo antes de guardarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los campos de entrada y etiquetas
            txtHorasTrabajadas.Text = "";
            txtHorasExtras.Text = "";
            cmbAFP.SelectedIndex = -1;
            cmbSalud.SelectedIndex = -1;
            lblSueldoBruto.Text = "";
            lblDescuentoAFP.Text = "";
            lblDescuentoSalud.Text = "";
            lblSueldoLiquido.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (sueldoCalculado)
            {
                // Crear una instancia de la ventana "ListarTrabajadores"
                ListarTrabajadores nuevaVentana = new ListarTrabajadores();

                // Mostrar la nueva ventana
                nuevaVentana.ShowDialog(); // Si deseas que esta ventana sea modal
                                           // O
                                           // nuevaVentana.Show(); // Si deseas que esta ventana sea no modal
            }
            else
            {
                // Muestra un mensaje de error si se intenta listar sin calcular y guardar el sueldo primero.
                MessageBox.Show("Debes calcular y guardar el sueldo antes de listar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void lblDescuentoSalud_Click(object sender, EventArgs e)
        {
            // Este método no se utiliza en este ejemplo.
        }
    }
}


