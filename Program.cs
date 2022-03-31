using Classes;
namespace Classes
{
    class Program 
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)

        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarSeries();

                    case "2":
                    InserirSeries();

                    case "3":
                    AtualizarSeries();

                    case "4":
                    ExcluirSeries();

                    case "5":
                    VisualizarSeries();

                    case "C":
                    Console.Clear();

                    default:
                    throw  new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigada por utilizar os nosso serviços.");
            Console.ReadLine();

        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }

        }
         private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Séries a seu dispor!!!");
                Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1 - Listar séries");
                Console.WriteLine("2 - Inserir nova série");
                Console.WriteLine("3 - Atualizar série");
                Console.WriteLine("4 - Excluir série");
                Console.WriteLine("5 - Visualizar série");
                Console.WriteLine("C - Limpar tela");
                Console.WriteLine("X - Sair");
     

            }
    }

}