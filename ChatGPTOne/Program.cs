using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string question, response;
            bool exit = true;

            // pergunta ao utilizador
            while (exit == true)
            {
                Console.Write("What is your question? ");
                question = Console.ReadLine();

                // Respostas as perguntas
                switch (question)
                {
                    case "EXIT":
                        response = "";
                        exit = false;
                        break;
                    case "Who are you?":
                        response = "Your worst enemy muahaha!";
                        break;
                    case "How can i be better in school?":
                        response = "you can't womp womp";
                        break;
                    case "Where do u live?":
                        response = "Jupiter";
                        break;
                    case "How can i be intelligent like you?":
                        response = "Don't even try";
                        break;
                    default:
                        response = "i can't answer that question ";
                        break;
                }

                // Responder adequadamente
                Console.WriteLine(response);       
                
            }
        }
    }
}
