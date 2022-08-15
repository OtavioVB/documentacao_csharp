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