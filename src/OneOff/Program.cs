using FatCat.Logger;
using FatCat.Toolkit.Console;

namespace OneOff;

public class Program
{
	public static void Main(params string[] args)
	{
		Console.WriteLine("Hello Fat Cat Logger");

		var consoleLogger = new ConsoleLogger(new ConsoleAccess());
		
		consoleLogger.Information("This is an information message");
	}
}