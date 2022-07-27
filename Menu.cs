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
    }
}