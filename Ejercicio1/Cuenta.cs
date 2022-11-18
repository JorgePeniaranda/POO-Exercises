using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Cuenta
    {
        string titular;
        double cantidad;
        public string Titular { get { return titular; } set { titular = value; } }
        public double Cantidad { get { return cantidad; } set { cantidad = value; } }


        public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }


        public bool Ingresar(double cantidadIngresar)
        {
            if (cantidadIngresar > -1) // Ingreso un numero Positivo
            {
                this.cantidad += cantidadIngresar;
                return true;
            }
            else return false; // Ingreso un numero negativo
        }
        public bool Retirar(double cantidadRetirar)
        {
            if (cantidadRetirar < 0) return false; // Esto para evitar que el usuario ingrese valores negativos y se agregue dinero mediante este metodo
            else if (this.cantidad - cantidadRetirar < 0) // El valor ingresado es mayor a la cantidad actual 
            {
                this.cantidad = 0;
                return false;
            }
            else // El valor ingresado es menor a la cantidad actual
            {
                this.cantidad -= cantidadRetirar;
                return true;
            }
        }
    }
}
