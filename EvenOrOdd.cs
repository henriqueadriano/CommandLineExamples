class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Type a number or 'E' to exit.");
                var userImput = Console.ReadLine();
                int outNumber;
                if(int.TryParse(userImput, out outNumber)){
                    if (outNumber % 2 == 0)
                        Console.WriteLine("The number {0} is even.", outNumber);
                    else
                        Console.WriteLine("The number {0} is odd.", outNumber);
                }
                else if (userImput.ToUpper().Equals("E"))
                {
                    loop = false;
                    Console.WriteLine("See you later...");
                    Console.Read();
                }
            }
        }
    }
