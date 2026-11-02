# Exemplos de orientação a objetos em C#

Console didático com herança, polimorfismo, cálculo, conta e operações de arquivos.

## Comportamento

- Créditos acumulam saldo e rejeitam valores negativos ou não finitos.
- Cálculos inteiros detectam overflow; divisão por zero retorna ao menu.
- Retângulo invalida medidas anteriores quando uma nova tentativa é inválida.
- Criação de texto preserva arquivos existentes usando `FileMode.CreateNew`.
- Exclusão limita-se a pastas vazias e exige a palavra APAGAR; caminho é exibido antes da operação.
- Leitura de números com recuperação e encerramento por EOF; .NET 10 LTS.

## Executar e validar

SDK .NET 10. Use as opções indicadas no menu (`Pessoa`, `Area`, `Calcular`, `Credito`, `Dir`, `Criar`, `Del`, `Arquivo`, `Sair`).

```powershell
./build.ps1 -Test -Package
dotnet run --project ExemploPOO/ExemploPOO.csproj
```

Os testes usam somente um arquivo temporário criado pela própria suíte e verificam que uma segunda escrita não substitui o conteúdo.

## Limites

A calculadora usa inteiros e divisão inteira. As classes de pessoas são exemplos de herança. Operações de arquivos atuam no caminho informado pelo usuário; use uma pasta de exercícios. Não existe exclusão recursiva no programa.

## Manutenção e licença

Código autoral licenciado sob a [MIT](LICENSE). Dependências, ferramentas e materiais de terceiros mantêm suas próprias licenças e avisos.

Decisões e continuidade: [PROJECT_MEMORY.md](PROJECT_MEMORY.md).

A opção Computador informa sistema e processadores lógicos localmente; nome/idade, nota e salário também validam os limites do exercício.
