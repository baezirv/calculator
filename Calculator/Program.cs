public class Program
{
	public static void Main (string[] args)
	{
		while (true) {
			Console.WriteLine("Calculator v1.0.0");

			var operation = DisplayMenuAndGetOperation();
			var entryValue1 = ReadValue1FromConsole(operation);
			var entryValue2 = ReadValue2FromConsole(operation);

			switch (operation) {
				case 1:
					Addition(entryValue1, entryValue2);
					break;
				case 2:
					Subtraction(entryValue1, entryValue2);
					break;
				case 3:
					Multiplication(entryValue1, entryValue2);
					break;
				case 4:
					Division(entryValue1, entryValue2);
					break;
				case 5:
					Exponentiation(entryValue1, entryValue2);
					break;
				case 6:
					Environment.Exit(0);
					break;
			}
			Thread.Sleep(1000);
		}
	}

	private static int DisplayMenuAndGetOperation()
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
	
	private static double ReadValue1FromConsole(int operation)
	{
		const string OtherOperationMessage = "Please enter your first value";
		const string DivisionMessage = "Please enter the dividend value";
		const string ExponentiationMessage = "Please enter base value";
		Console.WriteLine(operation < 4 ? OtherOperationMessage : operation == 4 ? DivisionMessage : ExponentiationMessage);
		var entryValue1 = Convert.ToDouble(Console.ReadLine ());
		return entryValue1;
	}

	private static double ReadValue2FromConsole(int operation)
	{
		const string OtherOperationMessage = "Please enter your second value";
		const string DivisionMessage = "Please enter the divisor value";
		const string ExponentiationMessage = "Please enter the exponent value";
		Console.WriteLine(operation < 4 ? OtherOperationMessage : operation == 4 ? DivisionMessage : ExponentiationMessage);
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

	private static void Exponentiation (double baseValue, double exponent)
	{
		double result;
		
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