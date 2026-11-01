# Programa-exemplos

Exemplos de orientação a objetos em C# com pessoas, contas, cálculos e operações sobre arquivos e diretórios.

## Funcionalidades verificadas

- Herança e polimorfismo.
- Interfaces e calculadora.
- Modelos de pessoa, aluno, professor e diretor.
- Listagem, criação e exclusão de diretórios e arquivos.

## Operação e arquitetura verificadas

ExemploPOO/Program.cs apresenta o menu; Models contém exemplos de domínio, Interfaces os contratos e Helper/FileHelper.cs as operações em disco.

Arquivos principais: `ExemploPOO/Program.cs`, `ExemploPOO/Helper/FileHelper.cs`, `ExemploPOO/Models/Pessoa.cs`.

### Requisitos e execução

SDK .NET compatível com ExemploPOO/ExemploPOO.csproj.

```text
dotnet build ExemploPOO.sln
dotnet run --project ExemploPOO/ExemploPOO.csproj
```



### Testes e estado

Não foi identificada uma suíte automatizada específica para os fluxos descritos; valide a execução e os casos de borda antes de publicar.

Estado: projeto de estudo/experimental. Deploy ativo não foi confirmado nesta revisão.

### Limitações conhecidas

- As opções Criar, Del e Arquivo modificam o filesystem; utilizar somente diretório temporário de exercício.
- Nenhuma operação de arquivo foi executada nesta auditoria.

### Licença e manutenção

Nenhum arquivo de licença foi identificado nesta revisão; não foi adicionada uma nova licença. Atualize comandos e limitações quando houver mudança de comportamento.
