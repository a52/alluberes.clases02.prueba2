using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace alluberes.clases02.prueba2
{
    class Program
    {
        static void Main(string[] args)
        {


            //pruebas001();
            //prueba002();
            //prueba003();
            // preuba004();
            // prueba005();

            /// prueba006();
            prueba007();

            // Console.WriteLine("Hello World!");
            Console.Read();
        }

        static void pruebas001()
        {
            var variable1 = 0;
            var variable2 = 0;
            var variable3 = 0;



            // Console.WriteLine(string.Format("v1: {0} \n v2: {1} \n v2: {2} \n", variable1, variable2, variable3));
            Console.WriteLine(string.Format($"v1: {variable1} \n v2: {variable2} \n v3: {variable3} \n"));

            /// asignar valores diferentes a las variables
            variable1 = 1;
            variable2 = 2;
            variable3 = 3;

            Console.WriteLine(string.Format("asignar valores diferentes a las variables \n v1: {0} \n v2: {1} \n v2: {2} \n", variable1, variable2, variable3));


            /// asignar valor de la variable 1 a la variable 2
            variable2 = variable1;


            Console.WriteLine(string.Format("asignar valor de la variable 1 a la variable 2 \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));


            variable1 = variable3;

            /// asignar valor de la variable 3 a la variable 1

            Console.WriteLine(string.Format("asignar valor de la variable 3 a la variable 1 \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));



            /// Cambiar color de propiedad 3
            variable3 = 4;

            Console.WriteLine(string.Format("Cambiar color de propiedad 3 \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));



        }

        static void prueba002()
        {
            Carro variable1 = new Carro();
            Carro variable2 = new Carro();
            Carro variable3 = new Carro();




            /// asignar valores diferentes a las variables
            variable1.Color = "Rojo";
            variable2.Color = "Azul";
            variable3.Color = "Amarillo";

            Console.WriteLine(string.Format("asignar valores diferentes a las variables \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));


            /// asignar valor de la variable 1 a la variable 2
            variable2 = variable1;


            Console.WriteLine(string.Format("asignar valor de la variable 1 a la variable 2 \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));


            variable1 = variable3;

            /// asignar valor de la variable 3 a la variable 1

            Console.WriteLine(string.Format("asignar valor de la variable 3 a la variable 1 \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));




            /// Cambiar color de propiedad 3
            variable3.Color = "negro";
            Console.WriteLine(string.Format("Cambiar color de propiedad 3 \n v1: {0} \n v2: {1} \n v3: {2} \n", variable1, variable2, variable3));



        }

        static void prueba003()
        {
            var carro1 = new NuevoCarro();
            carro1.Color = ColoresDeCarros.amarillo;

            int color = (int)carro1.Color;

            Console.WriteLine($"Color de carro: {carro1.Color} = {color}");


            /// Asignacion de valor numerico a un enum
            carro1.Color = (ColoresDeCarros)1;

            Console.WriteLine($"Asignacion de valor numerico a un enum: {carro1.Color} = {color}");


            var carro2 = carro1;

            Console.WriteLine($"Asignacion de valor numerico a un enum: {carro1.Color} = {color} \n carro2: {carro1.Color}");


            /// cambiar color al carro 2
            carro2.Color = ColoresDeCarros.azul;
            Console.WriteLine($"Asignacion de valor numerico a un enum: {carro1.Color} = {color} \n carro2: {carro1.Color}");




        }

        static void preuba004()
        {

            /// pruebas de blucles
            var carro1 = new NuevoCarro();




            // Console.WriteLine($"Asignacion de valor numerico a un enum: {carro1.Color} ");

            for (int i = 0; i < 5; i++)
            {

                /// Asignacion de valor numerico a un enum
                carro1.Color = (ColoresDeCarros)i;
                Console.WriteLine($"Asignacion de valor numerico a un enum: {carro1.Color} ");
            }


        }

        static void prueba005()
        {
            /// pruebas de while
            var carro1 = new NuevoCarro();
            int valor001 = 0;

            while (valor001 < 5)
            {
                carro1.Color = (ColoresDeCarros)valor001;
                Console.WriteLine($"valor de variable: {valor001}\n Color: {carro1.Color}") ;
                
                valor001++;
            }


        }

        static void prueba006()
        {
            int[] arreglo = new int[5];

            for(int index = 0; index < 5; index++)
            {
                arreglo[index] = index;
            }

            foreach(var value in arreglo)
            {
                Console.WriteLine($"valor: {value} ");
            }

        }

        static void prueba007()
        {
            /// DO while
            var valor = false;
            var count = 0;

            Console.WriteLine("WHILE");
            while (valor)
            {
                
                Console.WriteLine($"valor: {valor} | count: {count}");
                if (count > 10) valor = false;
                count++;

            }
            // valor = true;
            // count = 0;

            Console.WriteLine("\n\nDO WHILE");

            do
            {
                Console.WriteLine($"valor: {valor} | count: {count}");
                if (count > 10) valor = false;
                count++;

            } while (valor);



        }

    }

    class Carro
    {
        public int Gomas { get; set; }
        public int puertas { get; set; }

        public string Color { get; set; }


        public override string ToString()
        {
            var result = Color.ToString();
            return result;
        }

    }
    class NuevoCarro
    {
        public int Gomas { get; set; }
        public int puertas { get; set; }

        public ColoresDeCarros Color { get; set; }


        public override string ToString()
        {
            var result = Color.ToString();
            return result;
        }

    }



    enum ColoresDeCarros
    {
        rojo ,
        azul ,
        amarillo ,
        verde 
    }



}
