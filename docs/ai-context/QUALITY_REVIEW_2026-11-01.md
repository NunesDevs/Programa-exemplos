# Revisão de qualidade — 2026-11-01

Console didático com herança, polimorfismo, cálculo, conta e operações de arquivos.

## Escopo

Leitura de fontes, documentação, configurações e scripts do projeto, excluindo dependências, metadados Git e saídas geradas. Sem alteração visual; mudanças de interface gráfica exigem Figma.

## Correções e decisões

- Créditos acumulam saldo e rejeitam valores negativos ou não finitos.
- Cálculos inteiros detectam overflow; divisão por zero retorna ao menu.
- Retângulo invalida medidas anteriores quando uma nova tentativa é inválida.
- Criação de texto preserva arquivos existentes usando `FileMode.CreateNew`.
- Exclusão limita-se a pastas vazias e exige a palavra APAGAR; caminho é exibido antes da operação.
- Leitura de números com recuperação e encerramento por EOF; .NET 10 LTS.

## Como validar

SDK .NET 10. Use as opções indicadas no menu (`Pessoa`, `Area`, `Calcular`, `Credito`, `Dir`, `Criar`, `Del`, `Arquivo`, `Sair`).

```powershell
./build.ps1 -Test -Package
dotnet run --project ExemploPOO/ExemploPOO.csproj
```

Os testes usam somente um arquivo temporário criado pela própria suíte e verificam que uma segunda escrita não substitui o conteúdo.

## Limites reais

A calculadora usa inteiros e divisão inteira. As classes de pessoas são exemplos de herança. Operações de arquivos atuam no caminho informado pelo usuário; use uma pasta de exercícios. Não existe exclusão recursiva no programa.

Confira `PROJECT_MEMORY.md` para continuidade. Os resultados executados estão registrados abaixo.

A opção Computador informa sistema e processadores lógicos localmente; nome/idade, nota e salário também validam os limites do exercício.

## Resultado executado

Build .NET 10 sem avisos/erros, testes de crédito, overflow, divisão por zero, medidas e preservação de arquivo temporário aprovados. Pacote win-x64 recupera divisão por zero no menu e encerra por EOF.

Publicação em produção não foi realizada. Pacotes foram preparados e a publicação da branch será registrada na auditoria local; integração e distribuição são coordenadas separadamente.
