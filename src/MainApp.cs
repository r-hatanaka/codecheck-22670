using System;

public class MainApp
{
    static public void Main (string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
           string output = String.Format("argv[{0}]: {0}", i, args[i]);
           Console.WriteLine(output);
        }
        Console.WriteLine("World");
        Console.WriteLine("D“cM’·");
        Console.WriteLine("codecheck");
    }
}
