namespace SectionB2212C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter a string: ");
            input = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Stack<char> vowelOrder = new Stack<char>();
            for(int i = 0;i<input.Length;i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelOrder.Push(input[i]);
                }
            }
            string output = "";
            for(int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    output += vowelOrder.Pop();
                }
                else
                {
                    output += input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}