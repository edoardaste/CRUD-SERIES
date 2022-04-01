
using Classes.IRepositorio;
using Classes.SerieRepositorio;
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
                    break;

                    case "2":
                    InserirSeries();
                    break;

                    case "3":
                    AtualizarSeries();
                    break;

                    case "4":
                    ExcluirSeries();
                    break;

                    case "5":
                    VisualizarSeries();
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    default:
                    throw  new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigada por utilizar os nosso serviços.");
            Console.ReadLine();

        }
        
        private static void VisualizarSeries()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        private static void ExcluirSeries()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }
        private static void AtualizarSeries()
        {
            Console.Write("Digite o id da série: ")
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach ( int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("igite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("igite o genero entre as opções acima: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("igite o genero entre as opções acima: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("igite o genero entre as opções acima: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie, genero:(Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);

        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if (lista.Equals(0))
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Excluido" : ""));
                
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