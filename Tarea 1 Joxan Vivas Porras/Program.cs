using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Joxan_Vivas_Porras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea Documentada Joxan Vivas
            //Se Piden los datos solicitados
            Console.WriteLine("Ingrese el numero de cedula: ");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de empleado (1-3): ");
            Console.WriteLine("(1.Operario) (2.Tecnico) (3.Profesional)");
            int Tipoemp = int.Parse(Console.ReadLine());
            //este if ayuda a invalidar cualquier numero que no este entre 1 y 3. los "||" significan OR (o)
            if (Tipoemp < 1 || Tipoemp > 3)
            {
                Console.WriteLine("Tipo de empleado inválido. Debe ser 1, 2 o 3.");
                return;
            }
            //si el numero es valido continua normalmente el programa
            Console.WriteLine("Cantidad de horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());
            //Este IF ayuda a evitar numeros negativos
            if (horas < 0)
            {
                Console.WriteLine("La cantidad de horas trabajadas no puede ser negativa.");
                return;
            }

            Console.WriteLine("Ingrese el precio por hora: ");
            double precio = double.Parse(Console.ReadLine());
            //Este IF ayuda a evitar numeros negativos
            if (precio < 0)
            {
                Console.WriteLine("El precio por hora no puede ser negativo.");
                return;
            }
            //Ahora calcuaré el salario ordinario
            double salarioordinario = horas * precio;
            //Defino la vaiable aumento y la del tipo de empleado para usarla en el If
            double aumento = 0;
            string tipoEmpleado = "";

            //IF para definir el aumento total según el tipo de empleado
            if (Tipoemp == 1)
            {
                aumento = salarioordinario * 0.15;
                tipoEmpleado = "Operario";
            }
            else if (Tipoemp == 2)
            {
                aumento = salarioordinario * 0.10;
                tipoEmpleado = "Tecnico";
            }
            else if (Tipoemp == 3)
            {
                aumento = salarioordinario * 0.05;
                tipoEmpleado = "Profesional";
            }
            //calculamos el salario bruto sumando el salario base y el aumento
            double salariobruto = salarioordinario + aumento;
            //Calculamos la deduccion de la ley (9.17%) sobre el salario bruto
            double deduccion = salariobruto * 0.0917;
            //Calculamos el salario neto restando la deduccion al salario bruto
            double salarioNeto = salariobruto - deduccion;
            //Mostramos los resultados
            Console.WriteLine("----------------Resultados----------------");
            Console.WriteLine("Cédula: " + cedula);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Tipo de empleado: " + tipoEmpleado);
            Console.WriteLine("Salario por horas: " + precio);
            Console.WriteLine("Horas trabajadas: " + horas);
            Console.WriteLine("Salario ordinario: " + salarioordinario);
            Console.WriteLine("Aumento: " + aumento);
            Console.WriteLine("Salario bruto: " + salariobruto);
            Console.WriteLine("Deducción CCSS: " + deduccion);
            Console.WriteLine("Salario neto: " + salarioNeto);

            //Traté de aprovehar al maximo lo visto en clase profe y ´trate de evitar que hubieran errores en el programa
            //espero que le guste el resultado final.
        }
    }
}
