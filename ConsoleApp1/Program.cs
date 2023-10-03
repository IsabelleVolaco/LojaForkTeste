using System;
using System.Collections.Generic;
namespace objetosorientados
{

    class Program
    {
        static List<Usuario> listaUsuarios = new List<Usuario>();
    

       // dskjbsflkasnfdlçskdjfslkdfj
        static void Main(string[] args)
        {
            MostrarMenu();

        }

         static void MostrarMenu()
        {
            switch (Menu.MenuPrincipal())
            {
                case "1":
                    CadastrarUsuario();
                    break;
                case "2":
                    LogarUsuario();
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    Console.WriteLine("tente novamente");
                    break;
            }
        }

        public static void CadastrarUsuario()
        {
            Console.WriteLine("Digite seu usuario e senha:");
            Console.WriteLine("Usuario:");
            Usuario usuario = new Usuario();


            usuario.Nome = Console.ReadLine();



            if (listaUsuarios.Exists(usuarioLista => usuarioLista.Nome == usuario.Nome))
            {
                Console.WriteLine("Nome de usuario em uso, escolha outro");
                return;
            }
            Console.WriteLine("Senha");
            usuario.Senha = Console.ReadLine();

            listaUsuarios.Add(usuario);
            Console.WriteLine("Cadastro realizado com sucesso");
            Console.WriteLine();
            Console.WriteLine("Digite 0 para voltar ao menu inicial");
            string opcaozero = Console.ReadLine();

            if (opcaozero == "0")
            {
                Console.Clear();
                MostrarMenu();
            }
        }
        public static void LogarUsuario()
        {
            Console.WriteLine("Digite seu usuario e senha:");



            Console.WriteLine("Usuario:");
            string nome = Console.ReadLine();



            Console.WriteLine("Senha:");
            string senha = Console.ReadLine();



            Usuario usuario = listaUsuarios.Find(usuarioLista => usuarioLista.Nome == nome && usuarioLista.Senha == senha);



            if (usuario != null)
            {
                Console.WriteLine("logado");
            }
            else
            {
                Console.WriteLine("incorreto");
            }

           
        }
    }
}

