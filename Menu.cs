using System;

namespace editorhtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;//Cor de fundo azul
            Console.ForegroundColor = ConsoleColor.Black;//Cor da letra preto     

            DrawScreen();

            WriteOptions();

            var option = short.Parse(Console.ReadLine());
        }

        public static void DrawScreen()//Função criada para desenhar a tela


        {
            Console.Write("+");
            for (int i = 0; i <=30; i++ )
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines ++)
            {
                Console.Write("|");
                for (int i = 0; i <=30; i++ )
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <=30; i++ )
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

        }
   
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);//Pede a posição em que vamos escrever.Primeiro selecionamos a linha, depois a coluna.
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("==================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");

        }


    }
}