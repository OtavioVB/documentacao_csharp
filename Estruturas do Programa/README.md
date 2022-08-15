# Estruturas do Programa - Método Principal

## Visão Geral

O método **estático Main** é o ponto de entrada e saída de todo o programa. Enquanto ele não for finalizado ou se não houver uma exceção sem tratamento ele continuará funcionando. De modo geral, a estrutura do método principal é dada pelo seguinte:

```csharp
using System;

namespace DocCSHARP.ProgramStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

**Observações:** A partir da versão 9.0.0 do C#, essa estrutura foi simplificada, de modo que não haja a necessidade de haver os namespaces, classes e o método declarado. Veja a seguir:

```csharp
using System;

Console.WriteLine("Hello World!");
```

## Como funciona os parâmetros do método principal

Os parâmetros do método principal é responsável por resgatar os argumentos da linha de comando do processo sendo executado. Quando não há nenhum fator de fora do programa que interfira na execução dele, não há nenhum valor de entrada então não há a necessidade de haver parâmetros:

```csharp
using System;

namespace DocCSHARP.ProgramStruct
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

No entanto, caso haja um ponto de entrada como nesse código:

```csharp
using System;

namespace DocCSHARP.ProgramStruct
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if(Convert.ToInt16(args[0]) == 1){
                Console.WriteLine("Deu certo!");
                return 1;
            }
            return 0;
            Console.WriteLine("Hello World!");
        }
    }
}
```
e
```powershell
dotnet build
dotnet run -- 1

if($LastExitCode -eq 0){
    Write-Host "Execução realizada com sucesso"
}else{
    Write-Host "A execução do programa não pôde ser realizada com sucesso"
}

Write-Host "Valor retornado = " $LastExitCode

Wait-Event Timer.Elapsed
```

Que também pode ser realizado dessa forma:
```csharp
public static int Main()
{
    string[] args = Environment.GetCommandLineArgs();
    int result = 0;

    if(int.TryParse(args[1], out result) == true){
        if(result == 1)
        {
            Console.WriteLine("Deu certo!");
            return 1;
        }
        System.Console.WriteLine(args[1].ToString());
    }

    Console.WriteLine("Hello World!");
    return 0;
}
```

Lembrando que o `dotnet run -- 1` é utilizado o 1 para passar como valor de entrada ao programa.

Vale ressaltar que quando é utilizado o comando `Environment.GetCommandLineArgs()` o primeiro valor do array de string's é o `diretório do arquivo` e não a variável de entrada.

```csharp
using System;

namespace DocCSHARP.ProgramStruct
{
    internal class Program
    {
        public static int Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            System.Console.WriteLine($"O programa está sendo executado em {args[0]} e seu valor de entrada é {args[1]}");
        }
    }
}
```