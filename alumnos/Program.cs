using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantalumno, libreta=0;
            string nombrealumno;
            double nota, notamayor = 0, notamenor = 0; 
            Console.WriteLine("Introducir numeros de alumnos");
            cantalumno = Convert.ToInt32(Console.ReadLine());

            for (int n = 1; n <= cantalumno; n++) 
            {
                Console.WriteLine("escribir nombre del alumno");
                nombrealumno = Convert.ToString(Console.ReadLine());
                Console.WriteLine("escribir libreta del alumno");
                libreta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("escribir la nota del alumno");
                nota = Convert.ToDouble(Console.ReadLine());

                if (nota > notamayor)
                {
                    notamayor = nota;
                }
                if (nota < notamenor || notamenor == 0)
                {
                    notamenor = nota;
                }
                 
            }
            Console.WriteLine("la nota mas alta es " + notamayor +  "su libreta es" + libreta); 
            Console.WriteLine("la nota mas baja es " + notamenor + "su libreta es" + libreta); //hacer libreta menor y mayor
            Console.ReadKey();//y tambien que imprima el alumno con menor y mayor nota

        }






    }
}













































