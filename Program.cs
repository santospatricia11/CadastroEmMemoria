using System;

namespace Dio.Series
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
                 case "2" :
                    InserirSeries();
                    break;
                case "3" :
                    AtualizarSeries();
                    break;
                case "4" :
                    ExcluirSeries();
                    break;
                 case "5" :
                    VisualizarSeries();
                    break;
                case "c" :
                    Console.Clear();
                    break;
                  default:
                    throw new ArgumentOutofRangeException();
              }
              opcaoUsuario = ObterOpcaoUsuario();
          }
          Console.WriteLine("Obrigado por usar nossos serviços.");
          Console.ReadLine();
          
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");
            var lista = repositorio.Lista();
            if(lista.Count ==0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluir();
               
                Console.WriteLine("# ID {0}: .{1}",serie.retornaId(), retornaTitulo(), (excluido ? "Excluido" : ""));
            }
            
            private static void InserirSerie()
            {
                Console.WriteLine("Nova série");
                foreach (int i in Enum.GetValues(typeof(Genero),i)))
                {
                    Console.WriteLine("{0}.{1}",i , Enum.GetNome(typeof(Genero),i));
                }
               Console.Write("Digite o gênero entre as opções acima:");
               int entreGenero = int.Parse(Console.ReadLine());

              Console.Write("Digite o título da série:");
              string entreTitulo = Console.ReadLine();

              Console.Write("Digite o ano de inicio da série:");
              int entreDoAno = int.Parse(Console.ReadLine());

              Console.Write("Digite a descrição da série:");
              string entreDescricao = Console.ReadLine();
              Series novaSerie = new Series(id :repositorio.ProximoId.
              genero:(Genero)entreGenero,titulo:entreTitulo,ano:entreDoAno,descricao:entreDescricao);
              repositorio.Insere(novaSerie);
            }
        }
        private static void AtualizarSerie()
        {
            Console.WriteLine("Nova série");
                foreach (int i in Enum.GetValues(typeof(Genero),i)))
                {
                    Console.WriteLine("{0}.{1}",i , Enum.GetNome(typeof(Genero),i));
                }
               Console.Write("Digite o gênero entre as opções acima:");
               int entreGenero = int.Parse(Console.ReadLine());

              Console.Write("Digite o título da série:");
              string entreTitulo = Console.ReadLine();

              Console.Write("Digite o ano de inicio da série:");
              int entreDoAno = int.Parse(Console.ReadLine());

              Console.Write("Digite a descrição da série:");
              string entreDescricao = Console.ReadLine();
              Series novaSerie = new Series(id :repositorio.ProximoId.
              genero:(Genero)entreGenero,titulo:entreTitulo,ano:entreDoAno,descricao:entreDescricao);
              repositorio.Insere(novaSerie);
            }
        
        
        private static string ObterOpcaoUsuario()
        {
         Console.WriteLine();
         Console.WriteLine("DIO Séries Disponiveis!!");
         Console.WriteLine("Informe opção desejada:");
         Console.WriteLine("1- Listar Séries");
         Console.WriteLine("2- Inserir nova série:");
         Console.WriteLine("3- Atualizar Série:");
         Console.WriteLine("4- Excluir série:");
         Console.WriteLine("5- Visualizar Série");
         Console.WriteLine("6- Limpar tela");
         Console.WriteLine(" X - Sair");
         Console.WriteLine();

         string opcaoUsuario = Console.ReadLine().ToUpper();
         Console.WriteLine();
         return opcaoUsuario;


        }
    

