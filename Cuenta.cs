using System;

namespace Ejercicio_Cuentas
{
    public class Cuenta
    {
        public int Numero { get; set;}
        public int Titular { get; set;}
        public int Saldo { get; set;}
        
        List<string>Titular = new List<string>();
    }
}