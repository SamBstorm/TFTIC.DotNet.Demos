using System;

namespace TFTIC.DotNet.Demos.DelegatesGeneric
{
    //delegate void MonDelegate1Param(string texte);
    //delegate void MonDelegate2Param(string texte,object arg);
    //delegate void MonDelegate3Param(string texte,object arg,object arg2);
    //delegate void MonDelegate4Param(string texte,object arg,object arg2, object arg3);
    class Program
    {
        static void Main(string[] args)
        {
            //MonDelegate1Param del;

            Action<string> del;
            del = Console.WriteLine;

            del("Hello World!");

            Console.WriteLine("toto");

            //Action = Tout délégué avec un retour VOID
            // On utilise la généricité pour préciser le type de nos paramètres
            Action<string, object> action = Console.WriteLine;

            action("Toto", new object());


            //Func = Tout délégué avec un retour différent de VOID
            Func<string> f;
            f = Console.ReadLine;

            string text = f();
        }
    }
}
