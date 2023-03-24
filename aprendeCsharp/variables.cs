using System;


namespace aprendeCsharp
{


    class Variables
    {
        static void Main_variables(string[] args)
        {

            string CadenaTexto = "Daniel Oquendo";
            string CadenaTexto_Objeto = "Colombia";
            int NumerosEnteros = 37;
            float NumeroDecimal = 0.0f;
            double Decimal_Grande = 23.0000054;
            decimal Decimal_Preciso = 12.04034034034003404M;
            char character1 = 'a';
            char character2 = '+';
            bool Verdadero = true;
            bool Falce = false;


            Console.WriteLine($"Mi nombre es {CadenaTexto}, tengo {NumerosEnteros} años y vivo en {NumeroDecimal} y mido {CadenaTexto_Objeto}.");

            Console.WriteLine($"Tengo {Decimal_Grande} litros de agua, pero estan a  {Decimal_Preciso} KM  de distancia.");

            Console.WriteLine($"Mi tipo de sangre es {character1}{character2}");
            Console.WriteLine($"Soy hombre? {Verdadero}, soy unniño? {Falce}");
        }
    }



}