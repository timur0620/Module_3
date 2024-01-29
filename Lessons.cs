namespace Module_3
{
    class Lessons
    {
        static void Work(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(10, 100);
            double num_2 = rand.NextDouble() * 100;

            int result = (num > num_2) ? 0 : 1;
            Console.WriteLine((num > num_2) ? 0 : 1);

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
            }
            for (int i = 1; i < 22; i += 2)
            {
                //Console.WriteLine(i);
            }
            for (double step = -1; step <= 0; step += 0.25f)
            {
                Console.WriteLine(step);
            }

            Console.WriteLine("Enter number;");
            int number = int.Parse(Console.ReadLine());

            bool flag = false;
            while (flag)
            {
                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("You number = 1");
                            number = 2;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("You number = 2");
                            number = 3;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You number = 3");
                            number = 4;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You number = 4");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You number = ???");
                            flag = false;
                            break;
                        }
                }

            }


        }
    }
}
