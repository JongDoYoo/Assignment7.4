namespace Assignment7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {   
                ParkingSystem parking = new(2, 3, 0);             
                Console.WriteLine("Please enter 1 to park a big car, 2 to park a medium car and 3 to park a small car");
                int output = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{parking.addCar(output)}");

            }
        }
        public class ParkingSystem
        {

            private int bigSpots;
            private int mediumSpots;
            private int smallSpots;
            
            public ParkingSystem(int big, int medium, int small)
            {
                bigSpots = big;
                mediumSpots = medium;
                smallSpots = small;
            }
            public bool addCar(int carType)
            {
                switch (carType)
                {
                    
                    case 1: 
                        if (bigSpots > 0)
                        {
                            bigSpots--;
                            Console.WriteLine("Access granted!");
                            return true;
                        }
                     
                        return false;

                    case 2: // Medium car
                        if (mediumSpots > 0)
                        {
                            mediumSpots--;
                            Console.WriteLine("Access granted!");
                            return true;
                        }
                        return false;
                    case 3: // Small car
                        if (smallSpots > 0)
                        {
                            smallSpots--;
                            Console.WriteLine("Access granted!");
                            return true;
                        }
                        return false;
                    default:
                        return false; 


                }
            }
        }



    }
}
