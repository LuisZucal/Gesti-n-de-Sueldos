using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ENE
{
    public partial class ListarTrabajadores : Form
    {
        private List<Trabajador> trabajadores;
        private List<string> sueldos;
        

        public ListarTrabajadores()
        {
            InitializeComponent();

            // Inicializa las listas para almacenar información de trabajadores y salarios.
            trabajadores = new List<Trabajador>();
            sueldos = new List<string>();

            // Lee y llena la información de trabajadores desde "informacion_empleado.txt".
            LeerDatosTrabajadoresDesdeArchivo("informacion_empleado.txt");

            // Lee y llena la información de salarios desde "informacion_sueldo.txt".
            LeerDatosSalariosDesdeArchivo("informacion_sueldo.txt");

            // Configura las columnas y llena el DataGridView.
            ConfigurarDataGridView();

            // Rellena el DataGridView con información de trabajadores y salarios.
            RellenarDataGridView();
        }

        // Método para leer y extraer información de trabajadores desde un archivo de texto.
        private void LeerDatosTrabajadoresDesdeArchivo(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                // Lee todas las líneas of the archivo de texto.
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    // Divide la línea en partes (suponiendo que está formateada con "|" como separador).
                    string[] partes = linea.Split('|');

                    if (partes.Length >= 3)
                    {
                        // La posición 0 contiene el RUT, la posición 1 contiene el nombre y la posición 2 contiene la dirección.
                        string rutEmpleado = partes[0].Trim();
                        string nombre = partes[1].Trim();
                        string direccion = partes[2].Trim();

                        // Crea un objeto Trabajador y agrégalo a la lista.
                        trabajadores.Add(new Trabajador(rutEmpleado, nombre, direccion));
                    }
                }
            }
        }

        // Método para leer y extraer información de salarios desde un archivo de texto.
        private void LeerDatosSalariosDesdeArchivo(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                // Lee todas las líneas del archivo de texto.
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    // Divide la línea en partes (suponiendo que está formateada con "|" como separador).
                    string[] partes = linea.Split('|');

                    if (partes.Length >= 4)
                    {
                        // La posición 3 contiene el salario líquido en este caso.
                        string salario = partes[3].Trim();

                        // Agrega el salario a la lista de sueldos.
                        sueldos.Add(salario);
                    }
                }
            }
        }
        







        // Configura las columnas del DataGridView.
        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Add("RutColumn", "RUT");
            dataGridView1.Columns.Add("NombreColumn", "Nombre");
            dataGridView1.Columns.Add("DireccionColumn", "Direccion");
            dataGridView1.Columns.Add("SueldoColumn", "SueldoLíquido");
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
        }

        // Rellena el DataGridView con información de trabajadores y salarios.
        private void RellenarDataGridView()
        {
            // Suponiendo que las listas de trabajadores y sueldos tienen datos correspondientes.
            for (int i = 0; i < trabajadores.Count; i++)
            {
                // Comprueba si existe un registro de salario correspondiente.
                string sueldo = i < sueldos.Count ? sueldos[i] : "No disponible";

                dataGridView1.Rows.Add(trabajadores[i].RutEmpleado, trabajadores[i].Nombre, trabajadores[i].Direccion, sueldo);
            }
        }

        // El resto de la clase permanece sin cambios.
        // (dataGridView1_CellContentClick y la clase Trabajador)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Modificar"].Index)
            {
                // Comprobar si el índice de fila clickeado está dentro de un rango válido.
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    // Obtener la fila seleccionada.
                    DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                    // Acceder a los datos de la fila seleccionada.
                    string rut = filaSeleccionada.Cells["RutColumn"].Value.ToString();
                    string nombre = filaSeleccionada.Cells["NombreColumn"].Value.ToString();
                    string direccion = filaSeleccionada.Cells["DireccionColumn"].Value.ToString();
                    string sueldo = filaSeleccionada.Cells["SueldoColumn"].Value.ToString(); // Obtener el salario líquido

                    // Abre un formulario de edición para permitir al usuario modificar los datos.
                    // Luego, actualiza los datos en la lista 'trabajadores' y en el DataGridView.

                    // Actualiza el salario líquido con el valor modificado.
                    filaSeleccionada.Cells["SueldoColumn"].Value = sueldos; // Actualiza el DataGridView

                    // Opcionalmente, guarda los datos modificados de regreso al archivo informacion_sueldo.txt si es necesario.
                }
            }
           
            else if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                    {
                        // Comprobar si el índice de fila clickeado está dentro de un rango válido.
                        if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                        {
                            // Preguntar al usuario para confirmar la eliminación.
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == DialogResult.Yes)
                            {
                                // Obtener la fila seleccionada.
                                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                                // Acceder a los datos de la fila seleccionada.
                                string rut = filaSeleccionada.Cells["RutColumn"].Value.ToString();

                                // Eliminar el registro correspondiente de la lista 'trabajadores'.
                                // Buscar el objeto Trabajador con el RUT coincidente y eliminarlo.

                                // Eliminar la fila correspondiente de 'dataGridView1'.
                                dataGridView1.Rows.Remove(filaSeleccionada);

                                // Eliminar el registro correspondiente de los archivos de texto
                                // informacion_empleado.txt e informacion_sueldo.txt.
                                // Puedes hacerlo abriendo los archivos, eliminando el registro y guardando los cambios.
                            }
                        }
                    }
        }
    }

    
    
}



