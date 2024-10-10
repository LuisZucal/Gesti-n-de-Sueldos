using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Verifica las credenciales (esto es un ejemplo, debes implementar tu lógica de autenticación)
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
            // Por ejemplo, podrías tener una base de datos de usuarios con roles asociados.
            // En este ejemplo simple, asumimos que el usuario "admin" es un administrador.
            return usuario == "admin";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación si el usuario hace clic en el botón "Cancelar"
            Application.Exit();
        }

        // Un array de trabajadores con su Rut y contraseña
        private Tuple<string, string>[] trabajadores = new Tuple<string, string>[]
        {
            new Tuple<string, string>("12345678-9", "1234"),  // Ejemplo de un Rut y contraseña
            new Tuple<string, string>("98765432-1", "9876")   // Otro ejemplo
            // Agrega aquí más trabajadores con sus Ruts y contraseñas
        };

        private bool sonCredencialesValidas(string rut, string contrasena)
        {
            // Verifica si las credenciales coinciden con los trabajadores
            foreach (var trabajador in trabajadores)
            {
                string rutTrabajador = trabajador.Item1;
                string contrasenaTrabajador = trabajador.Item2;

                // Compara el Rut y los primeros 4 dígitos de la contraseña
                if (rut == rutTrabajador && contrasena == contrasenaTrabajador)
                {
                    // Credenciales válidas
                    return true;
                }
            }

            // Credenciales incorrectas o Rut no encontrado
            return false;
        }
    }
}


