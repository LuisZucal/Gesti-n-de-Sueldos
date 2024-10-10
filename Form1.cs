using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LeerRutsDesdeArchivo();
        }

        private List<string> ruts; // Lista para almacenar los RUTs desde el archivo

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Verifica las credenciales
            if (sonCredencialesValidas(usuario, contrasena))
            {
                // Si las credenciales son válidas, abre la ventana del Usuario Normal
                var ventanaUsuario = new VentanaUsuarioNormal();
                ventanaUsuario.Show();

                // Cierra esta ventana de inicio de sesión
                this.Hide();
            }
            else if (esAdministrador(usuario))
            {
                // Credenciales válidas para administrador, abre la ventana del Administrador
                var ventanaAdmin = new VentanaAdministrador();
                ventanaAdmin.Show();

                // Cierra esta ventana de inicio de sesión
                this.Hide();
            }
            else
            {
                // Credenciales incorrectas, muestra un mensaje de error
                lblMensajeError.Text = "Credenciales incorrectas. Intente nuevamente.";
            }
        }

        private bool esAdministrador(string usuario)
        {
            // Implementa tu lógica para determinar si el usuario es un Administrador o un Usuario Normal
            // En este ejemplo simple, asumimos que el usuario "admin" es un administrador.
            return usuario == "admin";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación si el usuario hace clic en el botón "Cancelar"
            Application.Exit();
        }

        private void LeerRutsDesdeArchivo()
        {
            try
            {
                string[] lineas = File.ReadAllLines("informacion_empleado.txt");
                ruts = new List<string>();

                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split('|');
                    if (partes.Length >= 1)
                    {
                        string rut = partes[0].Trim();
                        ruts.Add(rut);
                    }
                }
            }
            catch (IOException ex)
            {
                // Manejo de errores en caso de que no se pueda leer el archivo
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool sonCredencialesValidas(string rut, string contrasena)
        {
            // Verifica si el usuario (RUT) ingresado se encuentra en el archivo
            if (ruts.Contains(rut))
            {
                // Obtiene el RUT almacenado en el archivo (el usuario) y sus primeros 4 dígitos como contraseña esperada
                string primeros4DigitosRut = rut.Substring(0, 4);

                // Compara los primeros 4 dígitos del RUT (usuario) con los primeros 4 dígitos de la contraseña ingresada
                if (contrasena.Length >= 4 && contrasena.Substring(0, 4) == primeros4DigitosRut)
                {
                    // Credenciales válidas
                    return true;
                }
            }

            // Credenciales incorrectas o RUT no encontrado en el archivo
            return false;
        }
    }
}



