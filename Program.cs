
using foroUnidadI;

//IMPLEMETACION DE CONCEPTOS BASICOS SOBRE LA POO
//HERENCIA
//ENCAPSULACION
//SOBRECARGA DE METODOS


//EJEMPLO SOBRECARGA DE METODO (encapsulacion)
class Program
{
    static void Main(string[] args)
    {
        Sobrecarga sobrecarga = new Sobrecarga();
        sobrecarga.Suma(10, "10");

        Console.WriteLine(sobrecarga.Suma(10, 15, 40));
    }
}

//EJEMPLO DE HERENCIA (encapsulacion)
//class Prueba
//{
//    static void Main(string[] args)
//    {
//        Herencia persona1 = new Herencia();
//        persona1.Nombre = "Juan";
//        persona1.Edad = 25;
//        Console.WriteLine("Los datos de la persona son: ");
//        persona1.Imprimir();

//        Empleado empleado1 = new Empleado();
//        empleado1.Nombre = "Maria";
//        empleado1.Edad = 42;
//        empleado1.Sueldo = 2524;
//        Console.WriteLine("Los datos del empleado son: ");
//        empleado1.Imprimir();

//        Console.ReadKey();
//    }
//}

//EJEMPLO DE ENCAPSULACION