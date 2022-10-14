namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Variables Exercise");

            string catName = "Henry";
            int catAge = 1;
            char catInitial = 'H';
            bool isFemale = false;
            double hisWeight = 2.6;
            decimal hisPawSize = 1.2m;
            Console.WriteLine($"My cats name is {catName}, He is {catAge} years old. His initial is {catInitial}. He is a girl which is {isFemale}. He weighs about {hisWeight} lbs. His paw size is {hisPawSize} cm.");

        }
    }
}