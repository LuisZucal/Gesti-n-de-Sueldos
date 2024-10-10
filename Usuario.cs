using System;

namespace ENE
{
    public class Usuario
    {
        public decimal HorasTrabajadas { get; set; }
        public decimal HorasExtras { get; set; }
        public string AFP { get; set; }
        public string Salud { get; set; }
        public decimal SueldoBruto { get; set; }
        public decimal DescuentoAFP { get; set; }
        public decimal DescuentoSalud { get; set; }
        public decimal SueldoLiquido { get; set; }

        public Usuario(decimal horasTrabajadas, decimal horasExtras, string afp, string salud)
        {
            HorasTrabajadas = horasTrabajadas;
            HorasExtras = horasExtras;
            AFP = afp;
            Salud = salud;
        }

        public Usuario()
        {
        }
    }
}


