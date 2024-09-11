namespace Topic_2___Assignment
{
    internal class Program
    { //Andre 
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.WriteLine(2024 - 16);
            Thread.Sleep(1000);
            Console.WriteLine((14 + 15 + 16)/ 3);
            Thread.Sleep(1000);
            Console.WriteLine(((14.0 + 15 + 16 + 17) / 4));
            Thread.Sleep(1000);
            Console.WriteLine(Math.Round(Math.PI *  ((3 * 3)) ,1) + "Cm^2");
            Thread.Sleep(1000);
            Console.WriteLine("C# Knows when to do math rather then sticking thigs together by where you put it in your string, for example if you put it outside of your quotation marks it will stick the numbers together and if you dont put any quotation marks then it will add your numbers together");
            Thread.Sleep(1000);
            Console.ReadLine ();
            
        }
    }
}
