using System.Diagnostics;
using FatCat.Logger;
using FatCat.Toolkit;
using FatCat.Toolkit.Console;

namespace OneOff;

public class Program
{
	public static IFatCatLogger Logger { get; set; }

	public static void Main(params string[] args)
	{
		Console.WriteLine("Hello Fat Cat Logger");

		// Logger = new StackTraceLogger();
		Logger = new ConsoleLogger(new ConsoleAccess(), new DefaultLogMessageFormatter(new DateTimeUtilities()));

		var runs = 1;
		var totalTime = TimeSpan.Zero;

		for (var i = 0; i < runs; i++)
		{
			var timer = Stopwatch.StartNew();

			Logger.Information("This is an information message");
			Logger.Warning("This is warning a message");
			Logger.Debug("This is a debug message");
			Logger.Error("An error message I am");
			Logger.Fatal("This was a fatal message.  Why I do not know");
			Logger.Verbose("This is a verbose message");

			var other = new AnotherClass();

			other.DoSomeWork();

			timer.Stop();

			totalTime += timer.Elapsed;
		}

		var avgTime = totalTime / runs;

		ConsoleLog.WriteMagenta($"For {runs} loops time too <{avgTime}>");
	}
}