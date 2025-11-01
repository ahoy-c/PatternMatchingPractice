using System.Drawing;
using System.Text;

namespace PatternMatchingPractice
{
    internal class Program
    {

        // This method takes an array of objects and classifies each element based on its type and value.
        // It returns a StringBuilder containing a description for each element.
        static StringBuilder ObjectClassifier(object[] itm)
        {
            StringBuilder all = new StringBuilder();
            foreach (object obj in itm)
            {
                string input = obj switch
                {
                    // If the object is an integer, classify as negative, small (<10), or big.
                    int num => num switch
                    {
                        < 0 => $"{num} is a negative number",
                        < 10 => $"{num} is a small number",
                        _ => $"{num} is a big number",
                    },

                    // If the object is a string, classify as empty, short, or long.
                    string str => str switch
                    {
                        "" => "Empty string",
                        { Length: <= 5 } => $"{str} is a short string",
                        _ => $"{str} is a long string"
                    },

                    // If the object is a Point, classify which quadrant it belongs to.
                    Point point => point switch
                    {   
                        { X: > 0, Y: > 0 } => $"{point.ToString()} is a point in the first quadrant",
                        { X: < 0, Y: > 0 } => $"{point.ToString()} is a point in the second quadrant",
                        { X: < 0, Y: < 0 } => $"{point.ToString()} is a point in the third quadrant",
                        { X: > 0, Y: < 0 } => $"{point.ToString()} is a point in the fourth quadrant",
                    },

                    // If the object is null.
                    null => "is a null",

                    // Default case for unknown types.
                    _ => "Unknown object"
                };

                all.AppendLine(input);
            }

            return all;
        }

        // This method generates an array of random objects.
        // The array can contain integers, strings, Points, or null values.
        // It takes an integer 'length' which defines how long the array will be.
        static object[] GetRandomArray(int length)
        {
            object[] array = new object[length + 1];
            Random random = new();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i  = 0; i < length; i++)
            {
                int num = (int)random.Next(0, 4);

                switch (num)
                {
                    case 0: array[i] = null; break;

                    case 1: array[i] = (int)random.Next(-100, 100); break;

                    case 2:
                        int length1 = random.Next(0, 20);
                        char[] chr = new char[length1];
                        for(int j = 0; j < length1; j++)
                        {
                            chr[j] = alphabet[random.Next(0, alphabet.Length)];
                        }
                        array[i] = new string(chr);
                        break;

                    case 3:
                        array[i] = new Point(random.Next(-50, 50), random.Next(-50, 50));
                        break;
                }

            }
            return array;

        }

        // You can also provide your own array instead of generating a random one to test the classifier.
        static void Main(string[] args)
        {
            object[] ar = GetRandomArray(25);
            Console.WriteLine(ObjectClassifier(ar).ToString());
        }
    }
}
