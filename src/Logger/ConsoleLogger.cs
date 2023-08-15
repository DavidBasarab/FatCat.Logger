using FatCat.Toolkit.Console;

// ReSharper disable MethodOverloadWithOptionalParameter

namespace FatCat.Logger;

public class ConsoleLogger : IFatCatLogger
{
	private readonly IConsoleAccess consoleAccess;

	public ConsoleLogger(IConsoleAccess consoleAccess) => this.consoleAccess = consoleAccess;

	public void Information(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		consoleAccess.WriteLineWithColor(ConsoleColor.Green, message);
	}

	public void Verbose(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		consoleAccess.WriteLineWithColor(ConsoleColor.Blue, message);
	}

	public void Debug(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		consoleAccess.WriteLineWithColor(ConsoleColor.Gray, message);
	}

	public void Warning(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		consoleAccess.WriteLineWithColor(ConsoleColor.Yellow, message);
	}

	public void Error(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		consoleAccess.WriteLineWithColor(ConsoleColor.Red, message);
	}

	public void Fatal(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		consoleAccess.WriteLineWithColor(ConsoleColor.DarkRed, message);
	}
}