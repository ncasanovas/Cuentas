using System;
using System.Collections.Generic;


namespace Ejercicio_Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> listaTitulares = new List<Cliente>();

            Cliente cliente = new Cliente();
            cliente.DNI = 152232323;
            cliente.Nombre="Rick";
            cliente.Apellido = "Sanchez";
            cliente.Mail = "rick@gmail.com";
            cliente.Telefono = 45934399;           
            

            listaTitulares.Add(cliente);

            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Apellido);


            Cuenta cuenta = new Cuenta();
            Console.WriteLine(cuenta.Numero=50000);
            Console.WriteLine(cuenta.Saldo = 6000);
        }
    }
}
