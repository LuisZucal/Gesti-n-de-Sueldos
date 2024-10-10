using System;
using System.Windows.Forms;

namespace ENE
{
    public partial class ListarTrabajadores : Form
    {
        private Trabajador[] trabajadores; // Array de trabajadores

        public ListarTrabajadores()
        {
            InitializeComponent();

            // Crea un array de trabajadores con algunos datos de ejemplo
            trabajadores = new Trabajador[]
            {
                new Trabajador("11111111-1", "Juan Pérez", "Calle 123", 2500.0),
                new Trabajador("22222222-2", "María López", "Avenida 456", 3000.0),
                new Trabajador("33333333-3", "Carlos Rodríguez", "Ruta 789", 2800.0)
            };

            // Configura las columnas del DataGridView
            dataGridView1.Columns.Add("RutColumn", "RUT");
            dataGridView1.Columns.Add("NombreColumn", "Nombre");
            dataGridView1.Columns.Add("DireccionColumn", "Dirección");
            dataGridView1.Columns.Add("SueldoColumn", "Sueldo Líquido");

            // Agrega las columnas de botones "Modificar" y "Eliminar"
            DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
            modificarButtonColumn.HeaderText = "Modificar";
            modificarButtonColumn.Text = "Modificar";
            modificarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(modificarButtonColumn);

            DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.HeaderText = "Eliminar";
            eliminarButtonColumn.Text = "Eliminar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(eliminarButtonColumn);

            // Llena el DataGridView con los datos de los trabajadores
            foreach (var trabajador in trabajadores)
            {
                dataGridView1.Rows.Add(trabajador.RUT, trabajador.Nombre, trabajador.Direccion, trabajador.SueldoLiquido);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Modificar"].Index)
            {
                // Código para manejar el evento de clic en el botón "Modificar" en la fila seleccionada
                // Puedes acceder a los datos de la fila seleccionada usando dataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value
                // Realiza la lógica de modificación aquí.
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                // Código para manejar el evento de clic en el botón "Eliminar" en la fila seleccionada
                // Puedes acceder a los datos de la fila seleccionada usando dataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value
                // Realiza la lógica de eliminación aquí.
            }
        }
    }

    public class Trabajador
    {
        public string RUT { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public double SueldoLiquido { get; set; }

        public Trabajador(string rut, string nombre, string direccion, double sueldoLiquido)
        {
            RUT = rut;
            Nombre = nombre;
            Direccion = direccion;
            SueldoLiquido = sueldoLiquido;
        }
    }

}

