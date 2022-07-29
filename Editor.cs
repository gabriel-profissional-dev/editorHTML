using System;
using System.Text;

namespace editorhtml
{
    public static class Editor//Criada uma classe chamada editor para usá - la no menu
    {
        static void Show()//Método para Modo de edição
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        static void Start()
        {
            var file = new StringBuilder();

            do//Comando para que, enquanto o usuário não apertar Esc, o aplicativo não fecha o modo de edição.
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine("Deseja salvar o arquivo?");//Lição de casa: Armazenar sim ou não do usuário. 
            //Se digitar não ele perde o arquivo. Se digitar sim ele vai chamar o visualizador, o view.
        }
    }
}