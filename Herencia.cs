using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foroUnidadI
{
    //Herencia
    public class Herencia
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }

    public class Empleado : Herencia
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }


    


}

