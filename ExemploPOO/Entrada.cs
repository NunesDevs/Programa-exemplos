using System;
using System.IO;
internal static class Entrada
{
    public static string Texto() => Console.ReadLine() ?? throw new EndOfStreamException();
    public static int Inteiro() {
        while (true) {
            if (int.TryParse(Texto(), out var value)) return value;
            Console.WriteLine("Informe um número inteiro válido.");
        }
    }
}
