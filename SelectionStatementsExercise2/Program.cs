namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your favorite subject in school? (please don't capitilize your answer)");
            string favSubject = Console.ReadLine();
            switch (favSubject)
            {
                case "math":
                    Console.WriteLine("I love math too!");
                    break;
                case "science":
                    Console.WriteLine("Science was my favorite too!");
                    break;
                case "english":
                    Console.WriteLine("boo! english was my least favorite!");
                    break;
                case "history":
                    Console.WriteLine("History is cool");
                    break;
                case "programming":
                    Console.WriteLine("programming is my all time fav!");
                    break;
                default: 
                    Console.WriteLine("you must have liked P.E.");
                    break;
            }
        }
    }
}