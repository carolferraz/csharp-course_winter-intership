namespace ParameterModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Calculator.Sum(new int[] { 3, 9, 5, 7 });
            int sum2 = Calculator.Sum2(3, 9, 5, 7);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int quadruple;
            Calculator.Quadruple(b, out quadruple);
            Console.WriteLine(quadruple);

        }
    }
}