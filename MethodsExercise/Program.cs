namespace
    MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static void HeyYou()

        { //-----------------------EXERCISE 1-----------------------------------------
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


            Console.WriteLine($"{color}");

            Console.WriteLine($"{animal}");

            Console.WriteLine($"{band}");




        }

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var amountOfTabels = Multiply(5, 20, 38);
            var amountOfPeople = Subtract(101, 47);
            var amoountOfCandy = Divide(77, 33);
            var amountOfPens = Modulus(100, 9);



            HeyYou();
        }
        

       
 

        }
        //---------------------EXERCISE 2------------------------------

    
   












    }
