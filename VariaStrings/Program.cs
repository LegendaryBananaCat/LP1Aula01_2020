using System;

namespace VariaStrings
{
    class Program
    {
        static string s = "Hello \t yessuuu \n gggg \u03A9"; // vai fazer indentação
        static string u = "Hello \\t yessuuu \\n gggg \\u03A9"; // \\ vai imprimir só um \
        static string t = @"Hello \t yesuuuu \n ggg \u03A9"; // vai imprimir literalmente
        static string y = @"""Hello \t yesuuuu \n ggg \u03A9"""; // """ vai imprimir so "
        static string x = "\"Hello Worldo\" \n"; // vai imprimir a "frase"

        static int m = 9; // variaveis atribuidas
        static int n = 2; // variaveis atribuidas

        static string o = "\nAnother" + "One" + "yeets";  //adiciona ao anterior
        static string p = "\nyes =" + m + " " + "no = " + n; //same but with values

        static string l = $"{m} plus {n} equals {m + n}"; //places values in the midle of a string text; '{}' can do math and stuff
        static string k = $@"Here we go again with the {n}\n"; //prints string exacly as it is written, but still changes the value in the '{}'

        static string j = String.Format("\nArg {0} e {1}", m,n); // Replaces {0} & {1} with the values
        static string h = String.Format("\nArg {1} e {0}", m,n); // {0} is always the fist number (m), regardless of '{}'s order;
        static string g = String.Format("\nArg {0} nº {1}", "yeet",n); // srtings of text can also replace the '{}'



        static void Main(string[] args)
        {
            Console.WriteLine(s);
            Console.WriteLine(u);
            Console.WriteLine(t);
            Console.WriteLine(y);
            Console.WriteLine(x);
            
            
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(o);
            Console.WriteLine(p);
            Console.WriteLine(l);
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(h);
            Console.WriteLine(g);

            Console.WriteLine("Valor de m e'{0}", m);
        }
    }
}
