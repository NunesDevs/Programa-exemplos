using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;

 Menu:
Console.WriteLine("############################################\n# Atividades sobre orientação a obj com C# #\n############################################\nMenu:\n  - Pessoa: Nome e idade.\n  - Area: Área retangulo.\n  - Aluno: Aluno, idade.\n  - Professor: Professor, idade e salário.\n  - Calcular: Calcula valores.\n  - Credito: Credita saldo na conta.\n  - Diretor: Nome, idade, salário e escola.\n  - Computador: Indefinido.\n  - Dir: Comandos Diretórios.\n  - Criar: Criar pastas.\n  - Del: Deleta diretórios.\n  - Arquivo: Cria arquivos e adiciona conteudo.\n  - Sair: Encerra programa.");

switch (Console.ReadLine()){

    case "Pessoa":
        Pessoa p1 = new Pessoa();
        Console.WriteLine("Qual é o seu nome?");
        p1.Nome = Console.ReadLine();
        Console.WriteLine("Qual é o sua idade?");
        p1.Idade = Int32.Parse(Console.ReadLine());
        p1.Apresentar();
    goto Menu;

    case "Area":
        System.Console.WriteLine("Primeiro valor: ");
        int a1 = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Segundo valor: ");
        int a2 = Int32.Parse(Console.ReadLine());
        Retangulo r = new Retangulo();
        System.Console.WriteLine("Calculando área...");
        r.DefinirMedidas(a1, a2);
        Console.WriteLine($"Área: {r.ObterArea()}");
    goto Menu;

    case "Aluno":
        Aluno p2 = new Aluno();
        Console.WriteLine("Qual é o seu nome?");
        p2.Nome = Console.ReadLine();
        Console.WriteLine("Qual é o sua idade?");
        p2.Idade = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Qual é a sua nota?");
        p2.Nota = Int32.Parse(Console.ReadLine());
        p2.Apresentar();
    goto Menu;

    case "Professor":
         Professor p3 = new Professor();
         Console.WriteLine("Qual é o seu nome?");
         p3.Nome = Console.ReadLine();
         Console.WriteLine("Qual é o sua idade?");
         p3.Idade = Int32.Parse(Console.ReadLine());
         Console.WriteLine("Qual é o seu salário?");
         p3.Salario = Int32.Parse(Console.ReadLine());
         p3.Apresentar();
    goto Menu;

    case "Calcular":
        System.Console.WriteLine("Primeiro valor: ");
        int x = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Segundo valor: ");
        int y = Int32.Parse(Console.ReadLine());
        
        Continha:
            System.Console.WriteLine("Menus:\n-Somar\n-Subtrair\n-Dividir\n-Multiplicar");
            ICalculadora calc = new Calculadora();
                if(Console.ReadLine() == "Somar" ){
                     Console.WriteLine("Resultado da soma: " + calc.Somar(x, y));
                } else if(Console.ReadLine()=="Multiplicar"){
                    Console.WriteLine("Resultado da multiplicação: " + calc.Multiplicar(x, y));
                } else if(Console.ReadLine()=="Subtrair"){
                    Console.WriteLine("Resultado da Subtração " + calc.Subtrair(x, y));
                } else if(Console.ReadLine()=="Dividir"){
                    Console.WriteLine("Resultado da Divisão: " + calc.Dividir(x, y));
                } else {
                    System.Console.WriteLine("Menu invalido");
                    goto Continha;
                } 
    goto Menu;

    case "Credito":
    var crt = Int32.Parse(Console.ReadLine());
        Corrente c = new Corrente();
        c.Creditar(crt);
        c.ExibirSaldo();
    goto Menu;

    case "Diretor":
        Diretor p4 = new Diretor();
        Console.WriteLine("Qual é o seu nome?");
        p4.Nome = Console.ReadLine();
        Console.WriteLine("Qual é o sua idade?");
        p4.Idade = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Qual é o seu salário?");
        p4.Salario = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Nome da escola:");
        p4.Escola = Console.ReadLine();
        p4.Apresentar();
    goto Menu;

    case "Computador":
        Computador c1 = new Computador();
        System.Console.WriteLine(c1.ToString);
    goto Menu;

    case "Dir":
        In:
        System.Console.WriteLine("Dir padrao C:\\");
        System.Console.WriteLine("Menus:\n-ListDir\n-ListArq");
        var caminho = "C:\\";
        FileHelper helper = new FileHelper();
        if(Console.ReadLine()=="ListDir"){
            helper.ListarDiretorios(caminho);
        } else if(Console.ReadLine()=="ListArq"){
            helper.ListarArquivos(caminho);            
        } else {
            System.Console.WriteLine("Invalido.");
            goto In;
        }
    goto Menu;

    case "Criar":
        FileHelper helper1 = new FileHelper();
        Action:
            var caminho1 = "C:\\";
            System.Console.WriteLine("Dir padrao C:\\");
            System.Console.WriteLine("Deseja mudar? Caso queira utilize: S");
                if(Console.ReadLine()=="S"){
                    System.Console.WriteLine(" Utilize - C:\\(seu caminho). Caso nao exista será criada outra pasta. ");
                    caminho1 = Console.ReadLine();
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta = Console.ReadLine();
                    var caminhoPathCombine = Path.Combine(caminho1, nomePasta);
                    System.Console.WriteLine("Criando dir... " + caminhoPathCombine);
                    helper1.CriarDiretorio(caminhoPathCombine);
                } else {
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta = Console.ReadLine();
                    var caminhoPathCombine = Path.Combine(caminho1, nomePasta);
                    System.Console.WriteLine("Criando dir... " + caminhoPathCombine);
                    helper1.CriarDiretorio(caminhoPathCombine);
                    System.Console.WriteLine("Voltando ao menu.");
                 }
    goto Menu;

    case "Del":
        FileHelper helper2 = new FileHelper();
        Actions:
            var caminho2 = "C:\\";
            System.Console.WriteLine("Dir padrao C:\\");
            System.Console.WriteLine("Deseja mudar? Caso queira utilize: S");
                if(Console.ReadLine()=="S"){
                    System.Console.WriteLine(" Utilize - C:\\(seu caminho). Caso nao exista será criada outra pasta. ");
                    caminho2 = Console.ReadLine();
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta1 = Console.ReadLine();
                    var caminhoPathCombine1 = Path.Combine(caminho2, nomePasta1);
                    System.Console.WriteLine("Apagando dir... " + caminhoPathCombine1);
                    helper2.ApagarDiretorio(caminhoPathCombine1);
                } else {
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta1 = Console.ReadLine();
                    var caminhoPathCombine1 = Path.Combine(caminho2, nomePasta1);
                    System.Console.WriteLine("Apagando dir... " + caminhoPathCombine1);
                    helper2.ApagarDiretorio(caminhoPathCombine1);
                    System.Console.WriteLine("Voltando ao menu.");
                } 
    goto Menu;

    case "Arquivo":
        FileHelper helper3 = new FileHelper();
        System.Console.WriteLine("Digite o diretório: ");
        var caminho3 = Console.ReadLine();
        System.Console.WriteLine("Nome do arquivo e extensão: ");
        var nomeArquivo = Console.ReadLine();
        var caminhoArquivo = Path.Combine(caminho3, nomeArquivo);
        System.Console.WriteLine("Conteudo: ");
        var textinho = Console.ReadLine();
        helper3.CriarArquivoTexto(caminhoArquivo, textinho);
    goto Menu;

    case "Sair":
        System.Console.WriteLine("Obrigado por testar meu código!!");
        Environment.Exit(0);
    break;

    default:

    System.Console.WriteLine("Menu invalido, tente novamente.");

    goto Menu;
 
 

}



