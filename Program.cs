using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml;

namespace alluberes.clases02.prueba2
{
    class Program
    {
        static void Main(string[] args)
        {


            //pruebas001();
            //prueba002();
            //prueba003();
            //preuba004();
            //prueba005();

            /// prueba006();
            // prueba007();
            // prueba008();
            // prueba009();
            // prueba010();
            prueba011();

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

        static void prueba008()
        {
            Console.WriteLine("condiciones if");

            var isInHome = false;
            var puertaAbierta = false;

            Console.WriteLine($"Antuane está en la casa? {isInHome}");
            Console.WriteLine($"Puerta abierta? {puertaAbierta}");


            Console.WriteLine("Santiago está");
            if (isInHome)
            {
                Console.WriteLine(" entrando a la casa");



            } else if (puertaAbierta)
            {
                Console.WriteLine(" entra a la casa y se come el queso de la nevera");
            } else
            {
                
                Console.WriteLine(" esperando hasta que llegue alguien...");

            }

        }

        static void prueba009()
        {
            var valor1 = 1;

            if (valor1 != 2)
            {
                valor1 = 1;
                // Console.WriteLine("Valor1 tiene UNO como valor...");
                Console.WriteLine("--- no es uno-- ");
            }

            if (valor1 == 1)
            {
                Console.WriteLine("esta ves si, Valor1 tiene UNO como valor...");
            }

            //var valor2 = (valor1 == 1);

            //Console.WriteLine($"valor1 = {valor1} \nvalor2 = {valor2}");


        }

        static void prueba010()
        {
            Carro carro = new Carro();

            if (carro is null)
            {
                Console.WriteLine("La variable carro es nula");
            }

            Console.WriteLine($"Color: {carro.Color}" ); 
        }

        static void prueba011()
        {

            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            int val1 = 1;
            int val2 = 2;

            carro1.Color = "Color 1";
            carro2.Color = "Color 2";

            if (carro1 == carro2)
            {
                Console.WriteLine("Es el mismo carro");
            } 
            else
            {
                Console.WriteLine($"No es el mismo carro \nCarro 1 : {carro1.Color} \nCarro 2: {carro2.Color}");
            }


            carro1 = carro2;

            if (carro1 == carro2)
            {
                Console.WriteLine("Es el mismo carro");
            }
            else
            {
                Console.WriteLine($"No es el mismo carro \nCarro 1 : {carro1.Color} \nCarro 2: {carro2.Color}");
            }


            carro2.Color = "Negro";
            Console.WriteLine($"COLORES \nCarro 1 : {carro1.Color} \nCarro 2: {carro2.Color}");




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
