namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite school subject? ");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                case "math":
                    Console.WriteLine("Math:\nMath sucks!");
                    break;
                case "Science":
                case "science":
                    Console.WriteLine("Science:\nIt's amazing what gets passed as science these days...");
                    break;
                case "History":
                case "history":
                    Console.WriteLine("History\nReal history is interesting!!!");
                    break;
                case "English":
                case "english":
                    Console.WriteLine("English\nEnglish is always a good skill to know.");
                    break;
                case "Gym":
                case "gym":
                case "P.E.":
                case "p.e.":
                case "PE":
                case "pe":
                case "Physical Education":
                case "physical education":
                case "Physical Ed":
                case "physical ed":
                    Console.WriteLine("Physical Education:\nIt's good to get exercise at school.");
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}