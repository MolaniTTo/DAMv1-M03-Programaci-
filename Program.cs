using System;
namespace Refactoring
{
    public class FirstRefactoringExercise
    {
        public static void Main(string[] args)
        {
            int quantity, input, errors = 0, answer = 1,
                MaxErrors = 3, Min = 5, Max = 150, i = 0;

            const string message = "Indica quants valors vols introduir:";
            const string MsgInput = "introdueix un valor entre el {0} i el {1} (inclosos). Tens {2} intents com a màxim";
            const string MsgAdvice = "El valor introduït no és vàlid."; 
            const string MsgIntents = "Has superat el total d'intents.";
            const string MsgResult = "El resultat és:";
           

            Console.WriteLine(message);
            quantity = Convert.ToInt32(Console.ReadLine());
        
            do
            {
                Console.WriteLine(MsgInput, Min, Max, MaxErrors);
                input = Convert.ToInt32(Console.ReadLine());

                if (input < Min || input > Max)
                {
                    Console.WriteLine(MsgAdvice);
                    errors++;
                }
                else
                {
                    answer *= input;
                    i++;

                }
            } while (i < quantity && errors<MaxErrors);

            Console.WriteLine(Verifica(answer, errors, MaxErrors, MsgIntents, MsgResult));


        }

        public static string Verifica(int answer, int errors, int MaxErrors, string MsgIntents, string MsgResult)
        {

            if (errors == MaxErrors)
            {
                return MsgIntents;
            }

            else { return MsgResult + answer; }


        }
    }
}
