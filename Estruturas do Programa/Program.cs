using System;

namespace DocCSHARP.ProgramStruct
{
    internal class Program
    {
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
    }
}