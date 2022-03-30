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
                    Console.WriteLine("PRIMER MÓDULO: Conceptos básicos\n");
                    Console.WriteLine("No podemos empezar a programar así del tirón, puede que este no sea el primer rodeo para varios y que los siguientes conceptos que vamos a tratar sean pan con queso para ellos, no obstante, muchos están empezando desde 0 y por lo tanto, es muy importante que se graben lo siguiente en la mente.\n");
                    Console.WriteLine("El primer concepto que tenemos es el de SOFTWARE. El software es básicamente un conjunto de instrucciones, programas o datos que son utilizados para hacer funcionar las computadoras y ejecutar tareas específicas. Lo contrario del hardware, que describe los aspectos físicos de una computadora.\n");
                    Console.WriteLine("El segundo concepto que tenemos es el de DESARROLLADOR. Un desarrollador es una persona que construye y crea software y aplicaciones. Escribe, depura y ejecuta el código fuente de una aplicación de software.\n");
                    Console.WriteLine("Un desarrollador es la persona clave detrás de todas las aplicaciones de software. Por lo general, los desarrolladores dominan al menos un lenguaje de programación y dominan el arte de estructurar y desarrollar el código de un software o un programa.\n");
                    Console.WriteLine("El tercer concepto que tenemos es el de LENGUAJE DE PROGRAMACIÓN. Es un lenguaje formal que, mediante una serie de instrucciones, le permite a un programador escribir un conjunto de órdenes, acciones consecutivas, datos y algoritmos para, de esa forma, crear programas que controlen el comportamiento físico y lógico de una máquina.\n");
                    Console.WriteLine("El cuarto concepto que tenemos es el de LENGUAJES COMPILADOS y LENGUAJES INTERPRETADOS.\n");
                    Console.WriteLine(" - Los lenguajes compilados son aquellos lenguajes de alto nivel que como su nombre lo sugiere, requieren de un compilador (programa que traduce un lenguaje de alto nivel en código máquina o lenguaje máquina) para traducirlo y crear la parte ejecutable.\n" + " - Mientras tanto, los lenguajes interpretados son aquellos lenguajes de programación también de alto nivel en donde el código fuente debe ser traducido a un lenguaje que la máquina entienda y pueda realizar, no crean un archivo externo.\n");
                    Console.WriteLine("El quinto concepto que tenemos es el de LENGUAJES DE ALTO NIVEL y LENGUAJES DE BAJO NIVEL.\n");
                    Console.WriteLine(" - Los lenguajes de programación de alto nivel tienen como objetivo facilitar el trabajo del programador, ya que utilizan unas instrucciones más fáciles de entender. Además, el lenguaje de alto nivel permite escribir códigos mediante idiomas conocidos (español, inglés, etc.) y luego, para ser ejecutados, se traduce al lenguaje de máquina mediante traductores o compiladores.\n" + " - Por otro lado, los lenguajes de programación de bajo nivel son lenguajes totalmente orientados a la máquina. Este tipo de lenguaje sirve de interfaz y crea un vínculo inseparable entre el hardware y el software. Además, ejercen un control directo sobre el equipo y su estructura física.\n");
                    Console.WriteLine("El sexto concepto que tenemos es el de ENTORNO DE DESARROLLO. Este es un conjunto de procedimientos y herramientas que se utilizan para desarrollar un código fuente o programa. Este término se utiliza a veces como sinónimo de entorno de desarrollo integrado (IDE), que es la herramienta de desarrollo de software utilizado para escribir, generar, probar y depurar un programa.\n");
                    Console.WriteLine("El séptimo concepto que tenemos es el de ALGORITMO. Este es un conjunto ordenado y finito de operaciones que permite hallar la solución de un problema, normalmente se asocian al ámbito informático pero no necesariamente pertenecen a esa área.\n");
                    Console.WriteLine("El octavo concepto que tenemos es el de PROCESO. Esto es una secuencia de acciones que se llevan a cabo para lograr un fin determinado. En la ingeniería de software, un proceso de software es una serie de actividades relacionadas que conducen a la elaboración de un producto de software.\n");
                    Console.WriteLine("El noveno y último concepto que tenemos es el de DIAGRAMA DE FLUJO. Este es un diagrama que describe un proceso, sistema o algoritmo informático. Se usan ampliamente en numerosos campos para documentar, estudiar, planificar, mejorar y comunicar procesos que suelen ser complejos en diagramas claros y fáciles de comprender. Los diagramas de flujo emplean rectángulos, óvalos, diamantes y otras numerosas figuras para definir el tipo de paso, junto con flechas conectoras que establecen el flujo y la secuencia.\n");
                    break;
            }
            Console.ReadKey();
                
        }
    }
}
