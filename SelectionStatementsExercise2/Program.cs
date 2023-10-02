namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite school subject? ");
            var subject = Console.ReadLine();
            var cleanUp = subject.ToLower();


            switch (cleanUp)
            {
                case "math":
                    Console.WriteLine("Math:\nMath sucks!");
                    break;
                case "science":
                    Console.WriteLine("Science:\nIt's amazing what gets passed as science these days...");
                    break;
                case "history":
                    Console.WriteLine("History:\nReal history is interesting!!!");
                    break;
                case "english":
                    Console.WriteLine("English:\nEnglish is always a good skill to know.");
                    break;
                case "gym":
                case "p.e.":
                case "pe":
                case "physical education":
                case "physical ed":
                    Console.WriteLine("Physical Education:\nIt's good to get exercise at school.");
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}