using System;

namespace VariaStrings
{
    class Program
    {
        static string s = "Hello \t yessuuu \n gggg \u03A9"; // vai fazer indentação
        static string u = "Hello \\t yessuuu \\n gggg \\u03A9"; // \\ vai imprimir só um \
        static string t = @"Hello \t yesuuuu \n ggg \u03A9"; // vai imprimir literalmente
        static string y = @"""Hello \t yesuuuu \n ggg \u03A9"""; // """ vai imprimir so "
        static string x = "\"Hello Worldo\""; // vai imprimir a "frase"

        static void Main(string[] args)
        {
            Console.WriteLine(s);
            Console.WriteLine(u);
            Console.WriteLine(t);
            Console.WriteLine(y);
            Console.WriteLine(x);
        }
    }
}
