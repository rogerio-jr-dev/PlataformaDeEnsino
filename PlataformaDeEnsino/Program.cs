using System;
using System.Globalization;
using System.Collections.Generic;
using PlataformaDeEnsino.Entities;


namespace DesafioPlataforma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lesson> list = new List<Lesson>();

            Console.Write("Quantas aulas tem o curso? ");
            int n = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine();//Pular a linha 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da {i}a aula: ");
                Console.Write("Conteúdo ou tarefa (c/t)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Beep(); 
                Console.Write("Título: ");
                string title = Console.ReadLine();
                Console.Beep();
                if (ch == 'c')
                {
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();
                    Console.Beep();
                    Console.Write("Duração em segundos: ");
                    int seconds = int.Parse(Console.ReadLine());
                    Console.Beep();
                    list.Add(new Video(title, url, seconds));
                } else
                {
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();
                    Console.Beep();
                    Console.Write("Quantidade de questões: ");
                    int questionCount = int.Parse(Console.ReadLine());
                    Console.Beep();
                    list.Add(new TasK(title, description, questionCount));
                }
                Console.WriteLine();//Pular linha
            }
            Console.WriteLine();//Pular linha 
            int totalSeconds = 0;
            foreach (Lesson lesson in list)
            {
                totalSeconds += lesson.Duration();
            }
            Console.WriteLine($"DURAÇÃO TOTAL DO CURSO = {totalSeconds} segundos ");

        }
    }
}