namespace ENE
{
    internal class Trabajador
    {
        public string RutEmpleado { get; private set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        

        public Trabajador(string rutEmpleado, string nombre, string direccion)
        {
            RutEmpleado = rutEmpleado;
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}