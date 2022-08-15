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

Os parâmetros do método principal é responsável por resgatar os argumentos da linha de comando do processo sendo executado. É possível