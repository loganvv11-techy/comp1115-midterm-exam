Console.WriteLine("Hello there! I'm going to pick a number between 1 and 100. I'll give you 7 attempts to guess it");
Random random = new Random();
int randomNumber = random.Next(1, 100);


    randomNumber = int.Parse(Console.ReadLine());


    do

        if (randomNumber < 1 || randomNumber > 100)
        {
            Console.WriteLine("Invalid number");
            randomNumber = int.Parse(Console.ReadLine());
        }


        else
        {
            Console.WriteLine("Yup thats in range");
            randomNumber = int.Parse(Console.ReadLine());
            

        } while (randomNumber < 100 || randomNumber > 1);

