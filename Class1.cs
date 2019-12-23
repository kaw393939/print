using System;

namespace print
{
    public interface IPrinter
    {
        public void Print(String input);
        public void Print(String[] input);
    }
    public class Printer : IPrinter
    {
        public void Print(String input) {
            Utilities.Print(input);
        }
        public void Print(String[] input)
        {
            foreach (string line in input)
            {
                Utilities.Print(line);
            }
        }
    }
    public static class Utilities {
        public static void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
