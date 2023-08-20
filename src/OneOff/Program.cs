using Amazon.Runtime.Internal.Util;
using FatCat.Logger;
using FatCat.Logger.TempToBeRemoved;
using FatCat.Toolkit.Console;

namespace OneOff;

public class Program
{
	public static ConsoleLogger Logger { get; set; }

	public static void Main(params string[] args)
	{
		Console.WriteLine("Hello Fat Cat Logger");

		Logger = new ConsoleLogger(new ConsoleAccess(), new DefaultLogMessageFormatter(new DateTimeUtilities()));

		Logger.Information("This is an information message");
		Logger.Warning("This is warning a message");
		Logger.Debug("This is a debug message");
		Logger.Error("An error message I am");
		Logger.Fatal("This was a fatal message.  Why I do not know");
		Logger.Verbose("This is a verbose message");

		var other = new AnotherClass();
		
		other.DoSomeWork();
	}
}