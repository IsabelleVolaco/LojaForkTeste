using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;



namespace objetosorientados
{
    public  class Menu
    {

        public static string MenuPrincipal()
        {
            Console.WriteLine("1 -- Cadastro");
            Console.WriteLine("2 -- Login");
            Console.WriteLine("3 -- Sair");

            Console.WriteLine("Escolha uma opcao para prosseguir");
            string opcao =  Console.ReadLine();
            return opcao;
         
        }
    }
}