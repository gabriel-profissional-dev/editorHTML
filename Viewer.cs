using System;
using System.Text.RegularExpressions;

namespace editorhtml
{

    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();
            //Os comandos acima foram criados para que, assim que editamos, o texto é exibido em tela e depois voltamos ao Menu.
        }
    
        public static void Replace(string text)//função criada para editar o texto digitado com html
        {
            //"text <strong>text</strong>"//Texto colocado dentro de Regex para exibir saída.
            var strong = new Regex(@"</s*strong[^>]*>(.*?)<\s*/\s*strong>");//Uma regular expression sempre começa e termina com um caracter de escape \. Basta inserir um @ na frente e ele entende tudo como string.
            Console.WriteLine(strong);
        }
        
    }
}