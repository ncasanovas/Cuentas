using System;

namespace Ejercicio_Cuentas
{
    public class Clientes
    {
        public int DNI { get; set;}
        public int Nombre { get; set;}
        public int Apellido { get; set;}
        public int Mail { get; set;}
        public int Telefono { get; set;}
        public DateTime Fecha_Nacimiento{ get; set;}
        

         public string NombreCompleto()
      {
          return string.Format("{0} {1}", this.Nombre, this.Apellido);
      }
    }


}