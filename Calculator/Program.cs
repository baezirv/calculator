public class Program
{
	public static void Main (string[] args)
	{
		do {
			Console.WriteLine("Calculator v1.0.0");

			int entryValue1;
			int entryValue2;

			switch (DisplayMenu()) {
				case 1:
					Addition(ReadValue1FromConsole(), ReadValue2FromConsole());
					Thread.Sleep(1000);
					break;
				case 2:
					Subtraction(ReadValue1FromConsole(), ReadValue2FromConsole());
					Thread.Sleep(1000);
					break;
				case 3:
					Multiplication(ReadValue1FromConsole(), ReadValue2FromConsole());
					Thread.Sleep(1000);
					break;
				case 4:
					Console.WriteLine("Please enter the dividend value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter the divisor value");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					Division(entryValue1, entryValue2);
					Thread.Sleep(1000);
					break;
				case 5:
					Console.WriteLine("Please enter the base value");
					entryValue1 = Convert.ToInt32(Console.ReadLine ());
					Console.WriteLine("Please enter the exponent");
					entryValue2 = Convert.ToInt32(Console.ReadLine ());
					Exponentiation(entryValue1, entryValue2);
					Thread.Sleep(1000);
					break;
				case 6:
					Environment.Exit(0);
					break;
			}
		} while (true);
	}

	private static int DisplayMenu()
	{
		Console.WriteLine("Select the operation option number you want to calculate");
		Console.WriteLine("1. Addition");
		Console.WriteLine("2. Subtraction");
		Console.WriteLine("3. Multiplication");
		Console.WriteLine("4. Division");
		Console.WriteLine("5. Exponentiation");
		Console.WriteLine("6. Exit");
		
		var selectedMenuOption = int.Parse(Console.ReadLine());
		return selectedMenuOption;
	}
	
	private static double ReadValue1FromConsole() {
		Console.WriteLine("Please enter your first value");
		var entryValue1 = Convert.ToDouble(Console.ReadLine ());
		return entryValue1;
	}

	private static double ReadValue2FromConsole()
	{
		Console.WriteLine("Please enter your second value");
		var entryValue2 = Convert.ToDouble(Console.ReadLine ());
		return entryValue2;
	}

	private static void Addition (double entryValue1, double entryValue2)
	{
		var addResult = entryValue1 + entryValue2;
		Console.WriteLine($"Result is {addResult}");
	}

	private static void Subtraction (double entryValue1, double entryValue2)
	{
		var subtractionResult = entryValue1 - entryValue2;
		Console.WriteLine($"Result is {subtractionResult}");
	}

	private static void Multiplication (double entryValue1, double entryValue2)
	{
		var multiplicationResult = entryValue1 * entryValue2;
		Console.WriteLine($"Result is {multiplicationResult}");
	}
	
	private static void Division (double dividend, double divisor)
	{
		double divResult;
		divResult = dividend / divisor;
		Console.WriteLine($"Result is {divResult}");
	}

	private static void Exponentiation (int baseValue, int exponent)
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
		Console.WriteLine($"Result is {result}");
	}
}