using System;

namespace _Deliverable1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous ? ");
            string vacationType = Console.ReadLine();
            Console.Write("How many are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());

            string destination = ""; string travel_suggestion = ""; string result;

            if(vacationType== "musical")
            {
                destination = "New Orleans";
            }else if (vacationType == "tropical")
            {
                destination = "Beach Vacation in Mexico";
            }
            else if (vacationType == "adventurous")
            {
                destination = "Whitewater Rafting the Grand Canyon";
            }
            else
            {
                Console.WriteLine("invalid entry");
            }
           
            if (groupSize >= 6)
            {
                travel_suggestion = "Charter Flight";
            }else if (groupSize>=3)
            {
                travel_suggestion = "Helicopter";
            }else if (groupSize >= 1)
            {
                travel_suggestion = "First Class";
            }
            else
            {
                Console.WriteLine("invalid entry");
            }
            
            result = "Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travel_suggestion + " to " + destination;

            Console.WriteLine(result);
        }
    }
}
