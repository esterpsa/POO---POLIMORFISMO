using System;
using POO___Polimorfismo.classes;

namespace POO___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //iNSTANCIAMOS UMA CLASSE FUNCIONÁRIO 
        
            Funcionarios fun = new Funcionarios();
            fun.Mostrar();
            fun.Mostrar("Ester");
            fun.Mostrar(2);

            Console.Beep();
        }
    }
}
