using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;

 Menu:
Console.WriteLine("############################################\n# Atividades sobre orientação a obj com C# #\n############################################\nMenu:\n  - Pessoa: Nome e idade.\n  - Area: Área retangulo.\n  - Aluno: Aluno, idade.\n  - Professor: Professor, idade e salário.\n  - Calcular: Calcula valores.\n  - Credito: Credita saldo na conta.\n  - Diretor: Nome, idade, salário e escola.\n  - Computador: Sistema e processadores.\n  - Dir: Comandos Diretórios.\n  - Criar: Criar pastas.\n  - Del: Deleta diretórios.\n  - Arquivo: Cria arquivos e adiciona conteudo.\n  - Sair: Encerra programa.");

try
{
switch (Entrada.Texto()){

    case "Pessoa":
        Pessoa p1 = new Pessoa();
        Console.WriteLine("Qual é o seu nome?");
        p1.Nome = Entrada.Texto();
        Console.WriteLine("Qual é o sua idade?");
        p1.Idade = Entrada.Inteiro();

        p1.Apresentar();
    goto Menu;

    case "Area":
    area:
        System.Console.WriteLine("Primeiro valor: ");
            int a1 = Entrada.Inteiro();
        System.Console.WriteLine("Segundo valor: ");
            int a2 = Entrada.Inteiro();

        Retangulo r = new Retangulo();
        System.Console.WriteLine("Calculando área...");
        r.DefinirMedidas(a1, a2);
        Console.WriteLine($"Área: {r.ObterArea()}");
        System.Console.WriteLine("Deseja calcular outra área? 'S' para continuar enter para menu.");
            var novamente = Entrada.Texto();

        if (novamente == "S")
        {
            System.Console.WriteLine("Retornando... ");
            goto area;
        }
        System.Console.WriteLine("Voltando ao menu... ");
    goto Menu;

    case "Aluno":
        Aluno p2 = new Aluno();
        Console.WriteLine("Qual é o seu nome?");
            p2.Nome = Entrada.Texto();
        Console.WriteLine("Qual é o sua idade?");
            p2.Idade = Entrada.Inteiro();
        Console.WriteLine("Qual é a sua nota?");
            p2.Nota = Entrada.Inteiro();

        p2.Apresentar();
    goto Menu;

    case "Professor":
         Professor p3 = new Professor();
         Console.WriteLine("Qual é o seu nome?");
            p3.Nome = Entrada.Texto();
         Console.WriteLine("Qual é o sua idade?");
            p3.Idade = Entrada.Inteiro();
         Console.WriteLine("Qual é o seu salário?");
            p3.Salario = Entrada.Inteiro();

         p3.Apresentar();
    goto Menu;

    case "Calcular":
        Continha:

        System.Console.WriteLine("###############\n# Calculadora #\n###############");
        System.Console.WriteLine("Primeiro valor: ");
            int x = Entrada.Inteiro();
        System.Console.WriteLine("Segundo valor: ");
            int y = Entrada.Inteiro();

            System.Console.WriteLine("Menus:\n 1 - Somar\n 2 - Subtrair\n 3 - Dividir\n 4 - Multiplicar");
                var escolhendo = Entrada.Inteiro();
            ICalculadora calc = new Calculadora();
                if (escolhendo == 1 )
                {
                    Console.WriteLine("Resultado da soma: " + calc.Somar(x, y));
                } else if (escolhendo == 2)
                {
                    Console.WriteLine("Resultado da Subtração " + calc.Subtrair(x, y));
                } else if (escolhendo == 3)
                {
                    Console.WriteLine("Resultado da Divisão: " + calc.Dividir(x, y));
                } else if (escolhendo == 4)
                {
                    Console.WriteLine("Resultado da multiplicação: " + calc.Multiplicar(x, y));
                } else {
                    System.Console.WriteLine("Menu invalido");
                }
                System.Console.WriteLine("Deseja realizar mais uma operação? 'S' para continuar enter para menu.");
                    var escolha1 = Entrada.Texto();

                if (escolha1 == "S")
                {
                    System.Console.WriteLine("Retornando... ");
                    goto Continha;
                }
                System.Console.WriteLine("Voltando ao menu... ");
    goto Menu;

    case "Credito":
        var crt = Entrada.Inteiro();
        Corrente c = new Corrente();
        c.Creditar(crt);

        c.ExibirSaldo();
    goto Menu;

    case "Diretor":
        Diretor p4 = new Diretor();
        Console.WriteLine("Qual é o seu nome?");
            p4.Nome = Entrada.Texto();
        Console.WriteLine("Qual é o sua idade?");
            p4.Idade = Entrada.Inteiro();
        Console.WriteLine("Qual é o seu salário?");
            p4.Salario = Entrada.Inteiro();
        System.Console.WriteLine("Nome da escola:");
            p4.Escola = Entrada.Texto();

        p4.Apresentar();
    goto Menu;

    case "Computador":
        Computador c1 = new Computador();
        System.Console.WriteLine(c1.ToString());
    goto Menu;

    case "Dir":
        In:
        System.Console.WriteLine("Dir padrao C:\\");
        var caminho = "C:\\";
        System.Console.WriteLine("Deseja mudar? Caso queira digite S, aperte enter para continuar.");
            var mudando1 = Entrada.Texto();

        if (mudando1 == "S")
        {
            System.Console.WriteLine("Novo caminho. Utilize C:\\ no inicio: ");
            caminho = Entrada.Texto();
        }
        System.Console.WriteLine("Menus:\n 1 - ListDir\n 2 - ListArq");
            var listagem = Entrada.Inteiro();
        FileHelper helper = new FileHelper();

        if (listagem == 1)
        {
            System.Console.WriteLine("Listando diretorios de " + caminho);
            helper.ListarDiretorios(caminho);
        } else if (listagem == 2)
        {
            System.Console.WriteLine("Listando arquivos de " + caminho);
            helper.ListarArquivos(caminho);
        } else
        {
            System.Console.WriteLine("Invalido.");
        }
        System.Console.WriteLine("Deseja realizar mais uma operação? 'S' para continuar enter para menu.");
            var escolha2 = Entrada.Texto();

            if (escolha2 == "S")
            {
                System.Console.WriteLine("Retornando... ");
                goto In;
            }
            System.Console.WriteLine("Voltando ao menu... ");

    goto Menu;

    case "Criar":
        FileHelper helper1 = new FileHelper();
        Action:
            var caminho1 = "C:\\";
            System.Console.WriteLine("Dir padrao C:\\");
            System.Console.WriteLine("Deseja mudar? Utilize: S ou N");
                var opc1 = Entrada.Texto();

            if (opc1 == "S")
            {
                System.Console.WriteLine(" Utilize - C:\\(seu caminho). Caso nao exista será criada outra pasta. ");
                    caminho1 = Entrada.Texto();
                System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta = Entrada.Texto();
                var caminhoPathCombine = Path.Combine(caminho1, nomePasta);
                System.Console.WriteLine("Criando dir... " + caminhoPathCombine);
                helper1.CriarDiretorio(caminhoPathCombine);
                } else if (opc1 == "N")
                {
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta = Entrada.Texto();
                    var caminhoPathCombine = Path.Combine(caminho1, nomePasta);
                    System.Console.WriteLine("Criando dir... " + caminhoPathCombine);
                    helper1.CriarDiretorio(caminhoPathCombine);
                } else {
                    System.Console.WriteLine("invalido.");
                }
                System.Console.WriteLine("Deseja realizar mais uma operação? 'S' para continuar enter para menu.");
                    var escolha3 = Entrada.Texto();

                if (escolha3 == "S")
                {
                    System.Console.WriteLine("Retornando... ");
                    goto Action;
                }
                System.Console.WriteLine("Voltando ao menu... ");
    goto Menu;

    case "Del":
        FileHelper helper2 = new FileHelper();
        Actions:
            var caminho2 = "C:\\";
            System.Console.WriteLine("Dir padrao C:\\");
            System.Console.WriteLine("Deseja mudar? Utilize: S ou N");
                var opc = Entrada.Texto();
                if (opc =="S")
                {
                    System.Console.WriteLine(" Utilize - C:\\(seu caminho). Caso nao exista será criada outra pasta. ");
                    caminho2 = Entrada.Texto();
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta1 = Entrada.Texto();
                    var caminhoPathCombine1 = Path.Combine(caminho2, nomePasta1);
                    System.Console.WriteLine("Apagando dir... " + caminhoPathCombine1);
                    System.Console.WriteLine("Confirme com APAGAR para remover a pasta vazia: " + Path.GetFullPath(caminhoPathCombine1));
                    if (Entrada.Texto() == "APAGAR") helper2.ApagarDiretorio(caminhoPathCombine1);
                } else if (opc == "N")
                {
                    System.Console.WriteLine("Nome da pasta: ");
                    var nomePasta1 = Entrada.Texto();
                    var caminhoPathCombine1 = Path.Combine(caminho2, nomePasta1);
                    System.Console.WriteLine("Apagando dir... " + caminhoPathCombine1);
                    System.Console.WriteLine("Confirme com APAGAR para remover a pasta vazia: " + Path.GetFullPath(caminhoPathCombine1));
                    if (Entrada.Texto() == "APAGAR") helper2.ApagarDiretorio(caminhoPathCombine1);
                }
                System.Console.WriteLine("Deseja realizar mais uma operação? 'S' para continuar enter para menu.");
                    var escolha = Entrada.Texto();

                if (escolha == "S")
                {
                    System.Console.WriteLine("Retornando... ");
                    goto Actions;
                }
                System.Console.WriteLine("Voltando ao menu... ");
    goto Menu;

    case "Arquivo":
     um:
        FileHelper helper3 = new FileHelper();
        System.Console.WriteLine("Digite o diretório, Padrão de inicio: C:\\ ");
            var caminho3 = Entrada.Texto();
        System.Console.WriteLine("Nome do arquivo e extensão: ");
            var nomeArquivo = Entrada.Texto();
            var caminhoArquivo = Path.Combine(caminho3, nomeArquivo);
        System.Console.WriteLine("Conteudo: ");
            var textinho = Entrada.Texto();
        System.Console.WriteLine("Criando arquivo... ");
        helper3.CriarArquivoTexto(caminhoArquivo, textinho);
        System.Console.WriteLine("Deseja realizar mais uma operação? S para continuar enter para menu.");
            var continuar = Entrada.Texto();

        if (continuar == "S"){
            goto um;
        }
    goto Menu;

    case "Sair":
        System.Console.WriteLine("Obrigado por testar meu código!!");
        Environment.Exit(0);
    break;

    default:

    System.Console.WriteLine("Menu invalido, tente novamente.");

    goto Menu;

}

}
catch (System.IO.EndOfStreamException) { return; }
catch (Exception error) when (error is ArgumentException || error is System.IO.IOException || error is UnauthorizedAccessException || error is OverflowException || error is DivideByZeroException || error is System.Collections.Generic.KeyNotFoundException)
{
    Console.WriteLine("Operação não concluída: " + error.Message);
    goto Menu;
}
