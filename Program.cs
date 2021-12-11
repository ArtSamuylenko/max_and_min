namespace max_and_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            var array = Array.ConvertAll(str.Split(' '), s => int.Parse(s));

            int max_array_value = array.Max();
            int min_array_value = array.Min();

            int max_array_index = Array.FindIndex(array, i => i == max_array_value);
            int min_array_index = Array.FindIndex(array, s => s == min_array_value);

            array[max_array_index] = min_array_value;
            array[min_array_index] = max_array_value;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Read();

        }
    }
}