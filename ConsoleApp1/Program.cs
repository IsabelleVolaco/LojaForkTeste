using alunos;
using objetosorientados;

namespace ConsoleApp1
{
    internal class Program
    {
        class Usuario
        {
            public string Nome { get; set; }
            public string Senha { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Página Inicial");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Sair");

            Console.WriteLine("Escolha uma opção para prosseguir");

            int opcao = 0;

            switch (opcao)
            {
                case 1:
                    CadastroUsuario();
                    break;
                case 2:
                    LoginUsuario();
                    break;
                case 3:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Tente novamente");
                    break;

            }
            
        }

        private static void LoginUsuario()
        {
            Console.WriteLine("Usuário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Senha:");
            string senha = Console.ReadLine();
        }

        private static void CadastroUsuario()
        {
            throw new NotImplementedException();
        }
    }
}