public class Program
{
	public static void Main (string[] args)
	{
		do {
			Console.WriteLine("Calculator v1.0.0");

			int entryValue1;
			int entryValue2;
			int result;
			int selectedMenuOption;
			Console.WriteLine("Select the operation option number you want to calculate");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Multiplication");
			Console.WriteLine("4. Division");
			Console.WriteLine("5. Exponentiation");
			Console.WriteLine("6. Exit");

			selectedMenuOption = int.Parse(Console.ReadLine ());

			switch (selectedMenuOption) {
				case 1:
					Console.WriteLine("Please enter your first value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter your second value");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					result = Addition(entryValue1, entryValue2);
					Console.WriteLine($"Result is {result}");
					Thread.Sleep(1000);
					break;
				case 2:
					Console.WriteLine("Please enter your first value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter your second value");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					result = Subtraction(entryValue1, entryValue2);
					Console.WriteLine($"Result is {result}");
					Thread.Sleep(1000);
					break;
				case 3:
					Console.WriteLine("Please enter your first value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter your second value");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					result = Multiplication(entryValue1, entryValue2);
					Console.WriteLine($"Result is {result}");
					Thread.Sleep(1000);
					break;
				case 4:
					Console.WriteLine("Please enter the dividend value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter the divisor value");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					result = Division(entryValue1, entryValue2);
					Console.WriteLine($"Result is {result}");
					Thread.Sleep(1000);
					break;
				case 5:
					Console.WriteLine("Please enter the base value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter the exponent");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					result = Exponentiation(entryValue1, entryValue2);
					Console.WriteLine($"Result is {result}");
					Thread.Sleep(1000);
					break;
				case 6:
					Environment.Exit(0);
					break;
			}

			// finish it without math library
			// add sum, substraction, multiplication, division & power
		} while (true);
	}

	private static int Addition (int entryValue1, int entryValue2)
	{
		int addResult;
		addResult = entryValue1 + entryValue2;
		return addResult;
	}

	private static int Subtraction (int entryValue1, int entryValue2)
	{
		int subtractionResult;
		subtractionResult = entryValue1 - entryValue2;
		return subtractionResult;
	}

	private static int Multiplication (int entryValue1, int entryValue2)
	{
		int multiplicationResult;
		multiplicationResult = entryValue1 * entryValue2;
		return multiplicationResult;
	}
	
	private static int Division (int dividend, int divisor)
	{
		int divResult;
		divResult = dividend / divisor;
		return divResult;
	}

	private static int Exponentiation (int baseValue, int exponent)
	{
		int result;
		
		if (exponent == 0) {
			result = 1;
		} else if (baseValue == 0) {
			result = 0;
		}
		else {
			// baseValue is added to result as if was already multiplied
			result = baseValue;
		
			for(int i = 1; i < exponent; i++){
				result = result * baseValue;
			}
		}
		return result;
	}
}