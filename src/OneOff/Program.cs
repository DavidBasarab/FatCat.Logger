using FatCat.Logger;
using FatCat.Logger.TempToBeRemoved;
using FatCat.Toolkit.Console;

namespace OneOff;

public class Program
{
	public static void Main(params string[] args)
	{
		Console.WriteLine("Hello Fat Cat Logger");

		var consoleLogger = new ConsoleLogger(new ConsoleAccess(), new DefaultLogMessageFormatter(new DateTimeUtilities()));

		consoleLogger.Information("This is an information message");
		consoleLogger.Warning("This is warning a message");
		consoleLogger.Debug("This is a debug message");
		consoleLogger.Error("An error message I am");
		consoleLogger.Fatal("This was a fatal message.  Why I do not know");
		consoleLogger.Verbose("This is a verbose message");
	}
}