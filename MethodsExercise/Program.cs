namespace
    MethodsExercise
{
    class Program
    {
        public static void HeyYou()

        {
            Console.WriteLine($"Hey you! What's your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you,{userName}! My favorite color is yellow, what's yours?");
            var color = Console.ReadLine();

            Console.WriteLine($"I love {color}! What's your favorite animal {userName}?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal}?! I would have never guessed. What about music? Who is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"I've heard of {band}!");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine($"Here's a little profile of what I've learned about you today,{userName}!");

            Console.WriteLine($"You like,");


            Console.WriteLine ($"{color}");

            Console.WriteLine($"{animal}");

            Console.WriteLine($"{band}");




        }
        static void Main(string[] args)
        {
            HeyYou();
        }

    }
}