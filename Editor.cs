using System;
using System.Text;

namespace editorhtml
{
    public static class Editor//Criada uma classe chamada editor para usá - la no menu
    {
        public static void Show()//Método para Modo de edição. Tornei público para ter acesso
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()//Tornei público para ter acesso
        {
            var file = new StringBuilder();

            do//Comando para que, enquanto o usuário não apertar Esc, o aplicativo não fecha o modo de edição.
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja salvar o arquivo? (1) Sim // (0) Não. ");//Lição de casa: Armazenar sim ou não do usuário. 
            //Se digitar não ele perde o arquivo. Se digitar sim ele vai chamar o visualizador, o view.

            Viewer.Show(file.ToString());
            /*
            int salvarOuNao = int.Parse(Console.ReadLine());

            switch(salvarOuNao)
            {
                case 0: Environment.Exit(0); break;
                case 1: Salvar(); break;
            }
            */
        }

        /*
        static void Salvar()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo? ");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(file);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso.");
            Console.ReadLine();       

        }
        */
    }
}