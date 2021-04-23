using System;

namespace EXERCICIO_01___ESTRUTURA_FOR
{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Mostre os ímpares de 1 até X, um valor por linha.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            int x = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= x; i++){ 
                if ( i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
