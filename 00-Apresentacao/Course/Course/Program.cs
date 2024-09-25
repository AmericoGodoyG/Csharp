using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            /*
               Armazanando um valor em uma variável do tipo sbyte
               sbyte aceita numeros negativos 
            */
            sbyte x = 100;


            /* 
               Armazanando um valor em uma variável do tipo byte
               o tipo byte não aceita numero negativo 0 
            */
            byte n1 = 126;


            /*
               Caso o valor passe de 255 ele ira para o limite oposto do tipo da var
               n2++ resulta no valor 0
            */
            byte n2 = 255;
            n2++;

            int n3 = 1000;


            //Limite do tipo int 2bilhores
            int n4 = 2147483647;


            // O sifixo L inidica que esta sendo usado um numero longo
            long n5 = 2147483648L;
            
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);

            // bool é usado para armazenar um valor verdade V ou F
            bool completo = false;


            /*  
                char é usado prar armzarnar um caractere unicode
                Aspas simples delimita o uso de um carácter
            */
            char genero = 'F';
            char letra = '\u0041'; // código unicode


            /* 
               float armazena numeros decimais 
               f indica que o número usado é do tipo float    
            */
            float n6 = 4.5f; 
            double n7 = 4.6;


            /* 
               string armazena uma sequência de caracteres Unicode, imutával
               Aspas duplas indicam a cadeia de caractres
            */
            string nome = "Maria";

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(nome);


            //Exibindo os valores mínimos e máximos do tipos
            int m1 = int.MinValue;
            int m2 = int.MaxValue;
            sbyte m3 = sbyte.MaxValue;
            long m4 = long.MaxValue;
            decimal m5 = decimal.MaxValue;

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
        }
    }
}   