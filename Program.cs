using System;

namespace WhichDoorWillYouPick
{
    class Program
    {
        static void Main(string[] args)
        {
            bool whichDoor;
            Console.WriteLine("Pick a door number between 1 and 5");
            int doorNumber = Convert.ToInt32(Console.ReadLine());

            if (doorNumber == 1 && doorNumber <= 5)
            {
                whichDoor = true;
            }
            else
            {
                whichDoor = false;
            }


            switch (doorNumber)
            {
                case 1:
                    Console.WriteLine("You chose door number 1, you won a cat!");
                    break;
                case 2:
                    Console.WriteLine("You chose door number 2, you won a lawn mower!");
                    break;
                case 3:
                    Console.WriteLine("You chose door number 3, you won one million dollars!");
                    break;
                case 4:
                    Console.WriteLine("You chose door number 4, you won a trip to Niagara Falls!");
                    break;
                case 5:
                    Console.WriteLine("You chose door number 5, you won a new house!");
                    break;
                default:
                    Console.WriteLine("You can't follow instructions, we are taking all your money!");
                        break;
            }
        }
    }
}
