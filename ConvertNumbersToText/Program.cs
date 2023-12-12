namespace ConvertNumbersToText
{
    internal class Program
    {
       // private static int readline;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please Enter any number not more than 4 digit or X to exit");

            string a = "x";

            string b;
            String[] ab = new string[4]; 

            //Console.WriteLine(a); 
            

            if (a != "X")
            {
                for (int i = 0; i < a.Length; i++)
                {
                    string number = Console.ReadLine();
                    //ab = number;

                    //Console.WriteLine(number); 
                    Console.WriteLine(a);
                    i++;
                }
                
            }
            
            else
            {
                Console.WriteLine("Goodbye");
            }
            

        }
    }
}
