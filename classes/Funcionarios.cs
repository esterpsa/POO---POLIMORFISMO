using System;

namespace POO___Polimorfismo.classes
{
    public class Funcionarios
    {
        public string [] lista = {"Ester", "Rebeca", "Thalita", "Karen"};

        public void Mostrar(){
             //Imprimos todos os dados que estão no array
            foreach(var item in lista)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice){
            //Mostramos apenaso dado que está no registro do Array
            Console.ForegroundColor = ConsoleColor.Blue;

            if(indice <= lista.Length){
                Console.WriteLine(lista[indice]);
            }

            // Console.WriteLine(lista[indice]);
            // Console.ResetColor();
        }

        public void Mostrar(string busca){
            //Fazemos uma busca no array para verificar se os textos coincidem 
            foreach(var item in lista)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;

                if(item == busca){
                    Console.WriteLine("Resultado da busca"+item);
                }


                Console.ResetColor();
            }

        }

      





    }

}