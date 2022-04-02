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
            Console.WriteLine("Seleccione el módulo que desea trabajar");
            int vMódulo = Int32.Parse(Console.ReadLine());
            Console.Clear();
            //Aqui comienza mucho texto
            switch (vMódulo)
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

                case 2:
                    Console.WriteLine("SEGUNDO MÓDULO: Tipos de datos, variables y operadores\n");
                    Console.WriteLine("C# es un lenguaje fuertemente tipado. Cada variable y constante tiene un tipo, al igual que cada expresión que se evalúa a un valor. Cada declaración de método especifica un nombre, el tipo y la clase (valor, referencia o salida) de cada parámetro de entrada y del valor de retorno.\n");
                    Console.WriteLine("Los 13 tipos predefinidos simples incluyen:\n ");
                    Console.WriteLine("Once tipos numéricos:\n - Ocho tipos enteros de varias longitudes, con y sin signo: sbyte, byte, short, ushort, int, uint, long y ulong.\n - Dos tipos de punto flotante: float y double.\n - Un tipo de mayor precisión llamado decimal, que a diferencia de float y double, puede representar números con fracciones exactas. Lo que lo hace adecuado para cálculos financieros, monetarios, operaciones aritméticas, etc.");
                    Console.WriteLine("Un tipo de carácter unicode, llamado char.\n - bool, Un tipo que representa dos valores, verdadero y falso.\n ");
                    Console.WriteLine("Los 3 tipos restantes o no simples son:");
                    Console.WriteLine(" - object, que es el tipo base de todos los demás tipos.\n - string, el cual representa un arreglo de caracteres Unicode.\n - dynamic, el cual es usado para escribir assemblies en lenguajes dinámicos.\n");
                    Console.WriteLine("A simple vista puede parecer complicado pero a la hora de ponerlo en práctica te vas a dar cuenta de lo fácil que es realmente utilizarlos (o al menos la mayoría de estos).\n");
                    Console.WriteLine("Pasando a los operadores, tenemos 4 tipos de operadores: aritméticos, lógicos, de asignación y relacionales.");
                    Console.WriteLine("Los operadores aritméticos permiten efectuar cálculos, es decir, operaciones matemáticas, en el contenido de las variables.");
                    Console.WriteLine("Suma     +\nSustracción     - \nMultiplicación     *\nDivisión      / \nMódulo (resto de la división entera)     % \n");
                    Console.WriteLine("Los operadores lógicos permiten combinar las expresiones en estructuras condicionales o de bucle.");
                    Console.WriteLine("Y              && \nO              || \nNegación       !  \n");
                    Console.WriteLine("Los operadores de asignación como su mismo nombre lo dice, sirven para asignar valores.");
                    Console.WriteLine("Asignación    = \nSuma 1++ \nResta 1-- \nSuma el número que se elija += \nResta el número que se elija -= \n");
                    Console.WriteLine("Finalmente, tenemos los operadores relacionales o de comparación, comparan sus operadores.");
                    Console.WriteLine("Compara si los operadores son iguales     == \nCompara si el operador es menor que otro < \nCompara si el operador es mayor que otro > \nCompara si el operador es menor o igual que otro <= \nCompara si el operador es mayor o igual que otro >= \n");
                    break;
                case 3:
                    Console.WriteLine("TERCER MÓDULO: Decisiones\n");
                    Console.WriteLine("En c# tenemos dos tipos de estructuras en la toma de decisiones: la estructura if y la estructura switch.\n");
                    Console.WriteLine("Dos conceptos importantes al tratar con decisiones son acumulador y contador: el ACUMULADOR es una variable que se utiliza para sumar valores. Se utiliza normalmente dentro de un ciclo pero cambiamos su valor sumándole una variable, es decir, no siempre se le suma la misma cantidad. Mientras tanto, el CONTADOR es una variable que se utiliza para contar algo. Normalmente usamos un contador dentro de un ciclo y cambiamos su valor sumándole o restándole una constante, es decir, siempre se le suma o resta la misma cantidad. El caso más utilizado es incrementar la variable en uno.\n");
                    Console.WriteLine("En la estructura if tenemos 3 tipos: If then, if then else y por último, if then else if (if anidado).");
                    Console.WriteLine("IF THEN, significa que si la condición que colocamos es cierta, el programa hará una cosa, sin ninguna consecuencia si esta condición no se cumple.");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("DisplayWeatherReport(15.0);  // Output: Cold. \nDisplayWeatherReport(24.0);  // Output: Perfect!\n");
                    Console.WriteLine("void DisplayWeatherReport(double tempInCelsius)\n{\n     if (tempInCelsius < 20.0)\n     {\n         Console.WriteLine("+"Cold."+");\n     }\n}\n-------------------------------------------------------------------\n");
                    Console.WriteLine("IF THEN ELSE, significa que si la condición que colocamos es cierta, el programa hará una cosa y si no es cierta, pues hará otra.\n");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("DisplayWeatherReport(15.0);  // Output: Cold.\nDisplayWeatherReport(24.0);  // Output: Perfect!\n \nvoid DisplayWeatherReport(double tempInCelsius)\n{\n    if (tempInCelsius < 20.0)\n    {\n        Console.WriteLine("+"Cold."+"); \n    } \n    else\n    {\n        Console.WriteLine("+"Perfect!"+");\n    }\n} \n-------------------------------------------------------------------\n");
                    Console.WriteLine("IF THEN ELSE IF, también conocido como if anidado, es una sentencia if que se encuentra dentro de otra sentencia if. Esto es considerado una mala práctica y si es usado, no se recomienda usar en más de 5 bloques.\n");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("DisplayCharacter('f');  // Output: A lowercase letter: f\nDisplayCharacter('R');  // Output: An uppercase letter: R\nDisplayCharacter('8');  // Output: A digit: 8\nDisplayCharacter(',');  // Output: Not alphanumeric character: ,\n");
                    Console.WriteLine("void DisplayCharacter(char ch)\n{\n  if (char.IsUpper(ch))\n  {\n      Console.WriteLine("+"An uppercase letter: {ch}"+ ");\n  } \n  else if (char.IsLower(ch))\n  {\n      Console.WriteLine($"+"A lowercase letter: { ch}"+ ");\n  }\n  else if (char.IsDigit(ch))\n  {\n      Console.WriteLine($"+"A digit: { ch}"+ ");\n  }\n  else\n  {\n      Console.WriteLine($"+"Not alphanumeric character: { ch}"+ ");\n  }\n}\n-------------------------------------------------------------------\n");
                    Console.WriteLine("Como mejor alternativa al if anidado tenemos nuestra segunda estructura, la estructura switch.\n SWITCH, es una estructura que nos permite evaluar más de un caso y se caracteriza por la selección de una opción entre varias.");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("DisplayMeasurement(-4);  // Output: Measured value is -4; too low.\n DisplayMeasurement(5);  // Output: Measured value is 5.\n DisplayMeasurement(30);  // Output: Measured value is 30; too high.\n DisplayMeasurement(double.NaN);  // Output: Failed measurement.\n");
                    Console.WriteLine("void DisplayMeasurement(double measurement)\n{\n    switch (measurement)\n    {\n        case < 0.0:\n            Console.WriteLine($"+"Measured value is { measurement }; too low."+ ");\n            break;\n \n       case > 15.0:\n            Console.WriteLine($"+"Measured value is { measurement }; too high."+");\n            break;\n \n        case double.NaN:\n            Console.WriteLine("+"Failed measurement."+");\n            break;\n \n        default:\n            Console.WriteLine($"+"Measured value is { measurement }."+");\n            break;\n    }\n}\n");
                    break;
                case 4:
                    Console.WriteLine("CUARTO MÓDULO: Bucles\n");
                    Console.WriteLine("Tenemos tres (técnicamente 4) tipos de bucles en c#: while, do while y for.\n");
                    Console.WriteLine("WHILE, esta sentencia comprueba una condición y ejecuta la sentencia o bloque de sentencias que sigue al while. Comprueba repetidamente la condición y ejecuta esas sentencias hasta que la condición es falsa.\n");
                    Console.WriteLine("------------Ejemplo------------\nint counter = 0;\nwhile (counter < 10)\n{\n    Console.WriteLine($"+"Hello World! The counter is { counter }"+");\n    counter++;\n}\n-------------------------------------------------------------------");
                    Console.WriteLine("DO WHILE, la sentencia anterior y esta son parecidas, no obstante, el bucle do while ejecuta primero el código y luego comprueba la condición.");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("int counter = 0\ndo\n{\n    Console.WriteLine($" + "Hello World! The counter is { counter }" + ");\n    counter++;\n} while (counter < 10);\n-------------------------------------------------------------------");
                    Console.WriteLine("Finalmente, FOR, esta sentencia se usa en aquellas situaciones en las cuales conocemos la cantidad de veces que queremos que se ejecute el bloque de instrucciones. Además del for, también tenemos el FOREACH, normalmente se utiliza cuando se trabaja con arreglos/colecciones para iterar a través de los elementos de los arreglos o colecciones. El bucle foreach itera a través de cada elemento, de ahí que se llame bucle foreach.");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("using System;\n\nnamespace Loop\n{\n    class ForEachLoop\n    {\n        public static void Main(string[] args)\n        {\n            char[] myArray = {'H','e','l','l','o'};\n\n            foreach(char ch in myArray)\n            {\n                Console.WriteLine(ch);\n            }\n        }\n    }\n}\n-------------------------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("QUINTO MÓDULO: Arreglos y Métodos\n");
                    Console.WriteLine("Los ARREGLOS, también se les conoce como Matrices o Arrays, estos almacenan una colección de datos del mismo tipo (int, float, double, String, etc.), con ello se evita declarar una infinidad de variables, del mismo tipo.\n");
                    Console.WriteLine("Por regla, toda matriz comienza en la posición 0 y llega hasta n, accedemos a sus valores por medio del índice que se coloca en la posición del valor referido. Todas las matrices consisten en ubicaciones de memoria contiguas.\n");
                    Console.WriteLine("Arreglos estándar:");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("int[] valores = new int[10] {0,1,2,3,4,5,6,7,8,9};\nstring[] países = new string[5] {"+"Argentina"+", "+ "Bolivia"+", " +"Perú"+", "+ "Chile"+", "+ "Colombia"+"}; //Inicialización omitiendo el tamaño de la matriz\n\nint[] valores = new int[] {0,1,2,3,4,5,6,7,8,9};\nstring[] países = new string[] {"+"Argentina"+", "+ "Bolivia"+", "+ "Perú"+","+ "Chile"+", "+ "Colombia"+"}\n//También podemos omitir el operador new\n\nint[] valores =  {0,1,2,3,4,5,6,7,8,9};\nstring[] países = {"+"Argentina"+", "+ "Bolivia"+", "+ "Perú"+", "+ "Chile"+", "+ "Colombia"+"};\n-------------------------------------------------------------------\nArreglos multidimensionales:");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("int[,] numeros = new int[3, 4] { {1, 2,3,4}, {9, 8,7,6}, {7, 6,2,5} };\nstring[,] regiones = new string[2, 3] { {" + "Argentina"+", "+ "Brasil"+", "+ "Perú" + "}" + "," + "{" + "USA"+", "+ "; México"+", "+ "Costa Rica" + "} }; //También podemos omitir el tamaño de la matriz\n\nint[,] numeros = new int[,] { {1, 2,3,4}, {9, 8,7,6}, {7, 6,2,5} };\nstring[,] regiones = new string[,] { {" + "Argentina"+", "+ "Brasil"+", "+ "Perú" + "}, {+" + "USA"+", "+ "; México"+", "+ "Costa Rica" + "} }; //Y tambien podemos olvidarnos del operador\n\nint[,] numeros =  { {1, 2,3,4}, {9, 8,7,6}, {7, 6,2,5} };\nstring[,] regiones = { {" + "Argentina"+", "+ "Brasil"+", "+ "Peru" + "}, {" + "USA"+", "+ "; Mexico"+", "+ "Costa Rica" + "} };\n-------------------------------------------------------------------");
                    Console.WriteLine("Los MÉTODOS, un método en C# es una secuencia de enunciados dentro de una unidad lógica en nuestro programa. Son una de las partes esenciales en cualquier aplicación, y proporcionan una forma poderosa de ejecutar operaciones de forma ordenada.");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("void Imprimir(string nombre)\n{\n   Console.WriteLine(" + "Hola" + " + nombre);\n}\n-------------------------------------------------------------------");
                    Console.WriteLine("Para invocar un método simplemente utilizamos: NombredelMetodo();");
                    Console.WriteLine("------------Ejemplo------------");
                    Console.WriteLine("int Sumar(int numero1, int numero2)\n{\n     return numero1 + numero2;\n}\n-------------------------------------------------------------------");
                    break;
            }
            Console.ReadKey();
            //Aqui acaba el mucho texto
        }
    }
}
