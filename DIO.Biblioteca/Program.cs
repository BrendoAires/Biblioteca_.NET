

using DIO.Biblioteca;
using DIO.Biblioteca.Class;
using DIO.Biblioteca.Enum;

LivroRepositorio repositorio = new LivroRepositorio();
    
    
    
    
    string opcaoUsuario = MenuOpcao();

    while (opcaoUsuario.ToUpper() != "X")
    {
        switch(opcaoUsuario)
        {
            case "1":
            ListarLivro();
            break;

            case "2":
            InserirLivro();
            break;

            case "3":
            AtualizarLivro();
            break;

            case "4":
            ExcluirLivro();
            break;

            case "5":
            VisualizarLivro();
            break;

            case "C":
            Console.Clear();
            break;

            case "X":
            
            break;
        }
        opcaoUsuario = MenuOpcao();
    }
    Console.ReadLine();



static string MenuOpcao()
    {
        Console.WriteLine();
        Console.WriteLine("Informe a Opção Desejada");

        Console.WriteLine("1 - Listar Livros");
        Console.WriteLine("2 - Inserir Novo Livro");
        Console.WriteLine("3 - Atualizar Livros");
        Console.WriteLine("4 - Excluir Livros");
        Console.WriteLine("5 - Visualizar Livros");
        Console.WriteLine("C - Limpar Livros");
        Console.WriteLine("X - Sair");

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();

        return opcaoUsuario;
    }

    void ListarLivro()
    {
        Console.WriteLine("----Listar Livros----");

        var lista = repositorio.Lista();

        if(lista.Count == 0)
        {
            Console.WriteLine("Nenhum Livro Encontrado");
            return;
        }
        foreach (var livro in lista)
        {
            var excluido = livro.retornaExcluido();
            if(!excluido)
            Console.WriteLine("#ID {0}: {1}", livro.retornaId(), livro.retornaTitulo());
        }
    }

    void InserirLivro()
    {
        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.WriteLine("Digite o gênero entre as opções: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o Título do Livro: ");
        string entradaTitulo = Console.ReadLine();

        Console.WriteLine("Informe a descrição do livro: ");
        string entradadescricao = Console.ReadLine();

        Console.WriteLine("Informe a editora do livro: ");
        string entradaEditora = Console.ReadLine();

        Console.WriteLine("Informe o autor do livro: ");
        string entradaAutor = Console.ReadLine();

        Console.WriteLine("Informe o número de páginas do livro: ");
        int entradaPages = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o ano de lançamento do livro: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Livro novoLivro = new Livro (id: repositorio.ProximoId(),
        genero: (Genero)entradaGenero,
        titulo:entradaTitulo,
        descricao: entradadescricao,
        editora: entradaEditora,
        autor:entradaAutor,
        pages: entradaPages,
        ano: entradaAno);
        repositorio.Insere(novoLivro);
    }

void VisualizarLivro()
{
    Console.WriteLine("Informe o Id o Livro");
    int indiceLivro = int.Parse(Console.ReadLine());

    var livro = repositorio.RetornaPorId(indiceLivro);
    Console.WriteLine(livro);
}

void ExcluirLivro()
{
    Console.WriteLine("Informe o Id o Livro");
    int indiceLivro = int.Parse(Console.ReadLine());

    repositorio.Exclui(indiceLivro);
}

void AtualizarLivro()
{
    Console.WriteLine("Informe o Id do livro");
    int indiceLivro = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.WriteLine("Digite o gênero entre as opções: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o Título do Livro: ");
        string entradaTitulo = Console.ReadLine();

        Console.WriteLine("Informe a descrição do livro: ");
        string entradadescricao = Console.ReadLine();

        Console.WriteLine("Informe a editora do livro: ");
        string entradaEditora = Console.ReadLine();

        Console.WriteLine("Informe o autor do livro: ");
        string entradaAutor = Console.ReadLine();

        Console.WriteLine("Informe o número de páginas do livro: ");
        int entradaPages = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o ano de lançamento do livro: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Livro atualizaLivro = new Livro (id: indiceLivro,
        genero: (Genero)entradaGenero,
        titulo:entradaTitulo,
        descricao: entradadescricao,
        editora: entradaEditora,
        autor:entradaAutor,
        pages: entradaPages,
        ano: entradaAno);
        repositorio.Atualiza(indiceLivro, atualizaLivro);
}



