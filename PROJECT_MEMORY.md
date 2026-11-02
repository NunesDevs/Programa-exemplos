# Memória do projeto

Revisão: 2026-11-01. Ler este arquivo e `docs/ai-context/QUALITY_REVIEW_2026-11-01.md` antes de retomar alterações.

## Objetivo e estado

Console didático com herança, polimorfismo, cálculo, conta e operações de arquivos.

Mudanças funcionais desta revisão:
- Créditos acumulam saldo e rejeitam valores negativos ou não finitos.
- Cálculos inteiros detectam overflow; divisão por zero retorna ao menu.
- Retângulo invalida medidas anteriores quando uma nova tentativa é inválida.
- Criação de texto preserva arquivos existentes usando `FileMode.CreateNew`.
- Exclusão limita-se a pastas vazias e exige a palavra APAGAR; caminho é exibido antes da operação.
- Leitura de números com recuperação e encerramento por EOF; .NET 10 LTS.

## Decisões

- Preservar o propósito didático e o histórico anterior do Git.
- Manter esta revisão na branch `codex/quality-refresh` até integração coordenada.
- Preservar arquivos locais e avisos de terceiros; não versionar resultados de build, credenciais ou dados reais.
- Artefatos de console são distribuíveis locais. Um build ou pacote não comprova publicação em produção.
- .NET 10 LTS foi escolhido porque .NET 3.1 e 6 estavam sem suporte e .NET 8 encerra suporte em 2026-11-10. Referência: https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core .

## Validação reproduzível

SDK .NET 10. Use as opções indicadas no menu (`Pessoa`, `Area`, `Calcular`, `Credito`, `Dir`, `Criar`, `Del`, `Arquivo`, `Sair`).

```powershell
./build.ps1 -Test -Package
dotnet run --project ExemploPOO/ExemploPOO.csproj
```

Os testes usam somente um arquivo temporário criado pela própria suíte e verificam que uma segunda escrita não substitui o conteúdo.

## Limitações para continuidade

A calculadora usa inteiros e divisão inteira. As classes de pessoas são exemplos de herança. Operações de arquivos atuam no caminho informado pelo usuário; use uma pasta de exercícios. Não existe exclusão recursiva no programa.

Os documentos automáticos de maio em `docs/ai-context` são um registro histórico, incluindo falsos positivos por palavras como “secret”. Esta memória e a revisão de qualidade descrevem o estado posterior às correções.

A opção Computador informa sistema e processadores lógicos localmente; nome/idade, nota e salário também validam os limites do exercício.

Pacotes Release omitem símbolos de depuração e mapeiam caminhos de origem em `Directory.Build.props`, para não distribuir caminhos locais. Para depurar, use a configuração Debug.

## Evidência da revisão

Build .NET 10 sem avisos/erros, testes de crédito, overflow, divisão por zero, medidas e preservação de arquivo temporário aprovados. Pacote win-x64 recupera divisão por zero no menu e encerra por EOF.
