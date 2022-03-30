using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Mini
    {
        static void Manon(string[] args)
        {
            Console.WriteLine("Seleccione el modulo que desea trabajar");
            int vModulo = Int32.Parse(Console.ReadLine());
            switch (vModulo)
            {
                case 1:
                    Console.WriteLine("PRIMER MÓDULO: Conceptos básicos");
                    Console.WriteLine("No podemos empezar a programar así del tirón, puede que este no sea el primer rodeo para varios y que los siguientes conceptos que vamos a tratar sean pan con queso para ellos, no obstante, muchos están empezando desde 0 y por lo tanto, es muy importante que se graben lo siguiente en la mente.");
                    Console.WriteLine("El primer concepto que tenemos es el de SOFTWARE. El software es básicamente un conjunto de instrucciones, programas o datos que son utilizados para hacer funcionar las computadoras y ejecutar tareas específicas. Lo contrario del hardware, que describe los aspectos físicos de una computadora.");
                    break;
            }
            Console.ReadKey();
                
        }
    }
}
