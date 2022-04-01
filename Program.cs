
using Classes.IRepositorio;
using Classes;
using System;
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
            var lista = repositorio.ListaSerie();

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
        
        private static async void InserirSeries()
        {
            foreach (var i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", await, Enum.GetName(typeof(Genero), i));
            }
                Console.WriteLine("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o gênero entre as opções acima: ");
                string entradaTitulo = Console.ReadLine();
                
                Console.WriteLine("Digite o titulo entre as opções acima: ");
                int entradaAno = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o gênero entre as opções acima: ");
                string entradaDescricao = (Console.ReadLine();

                Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
                
                repositorio.Insere(novaSerie);
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