namespace ParameterModifier
{
    class Calculator
    {
        //Below is a method that sum dynamically numbers that are pased as a parameter in an array.
        public static int Sum(int[] numbers) //This form of the method receive an array of int numbers, in which we need to declare the array everytime we call this method, for ex: Calculator.Sum(new int[] { num1, num2 });
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int Sum2(params int[] numbers) // Using "params" before the definition of the parameter the method will receive, we can use a simpler syntax were we don't need to declare the array when this function is called: Calculator.Sum( num1, num2 );
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
//When we call a method like the one below, the calculation will be saved in the method's scope variable (at x, in this example), so we need something to tell the program that it needs to pass the data to an externar variable (in this case, the variable "a" on the main scope). We use ref in the parameters and in the variable that is calling the method to pass this information. Note that to use this the variable needs to be iniciated, as we see on the 14th line.
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

//To use on a variable that has not been initialized we can use the out parameter. So we use an initialized variable as source data, and a second one as result, this one don't need to be initialized.
        public static void Quadruple(int origin, out int result)
        {
            result = origin * 4;
        }


    }
}