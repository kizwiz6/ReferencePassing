namespace ReferencePassing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numWithoutRef = 0;

            incrementValueWithoutRef(numWithoutRef);

            Console.WriteLine(numWithoutRef);


            int numWithRef = 0;

            incrementValueWithRef(ref numWithRef);

            Console.WriteLine(numWithRef);

            int[] arr = { 1, 2, 3 };
            modifyArray(arr);

            Console.WriteLine(arr[0] + " " + arr[1]);

        }

        /// <summary>
        /// Arrays are always passed by reference even when not specified via the ref keyword.
        /// </summary>
        /// <param name="arrayArg"></param>
        static void modifyArray(int[] arrayArg)
        {
            arrayArg[0] = 3;
            arrayArg[1] = 4;
        }

        /// <summary>
        /// Passed by value.
        /// </summary>
        /// <param name="num"></param>
        static void incrementValueWithoutRef(int num)
        {
            num++;
        }

        /// <summary>
        /// Passed by reference.
        /// </summary>
        /// <param name="num"></param>
        static void incrementValueWithRef(ref int num)
        {
            num++;
        }
    }
}
