using System.Runtime.CompilerServices;
using FatCat.Toolkit.Console;

// ReSharper disable MethodOverloadWithOptionalParameter

namespace FatCat.Logger;

public class ConsoleLogger : IFatCatLogger
{
	private readonly IConsoleAccess consoleAccess;
	private readonly ILogMessageFormatter logMessageFormatter;

	public ConsoleLogger(IConsoleAccess consoleAccess, ILogMessageFormatter logMessageFormatter)
	{
		this.consoleAccess = consoleAccess;
		this.logMessageFormatter = logMessageFormatter;
	}

	public void Information(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
	{
		var finalMessage = logMessageFormatter.GetMessage(LogLevel.Information, message, memberName, sourceFilePath, sourceLineNumber);

		consoleAccess.WriteLineWithColor(ConsoleColor.Green, finalMessage);
	}

	public void Verbose(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
	{
		var finalMessage = logMessageFormatter.GetMessage(LogLevel.Verbose, message, memberName, sourceFilePath, sourceLineNumber);

		consoleAccess.WriteLineWithColor(ConsoleColor.Blue, finalMessage);
	}

	public void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
	{
		var finalMessage = logMessageFormatter.GetMessage(LogLevel.Debug, message, memberName, sourceFilePath, sourceLineNumber);

		consoleAccess.WriteLineWithColor(ConsoleColor.Gray, finalMessage);
	}

	public void Warning(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
	{
		var finalMessage = logMessageFormatter.GetMessage(LogLevel.Warning, message, memberName, sourceFilePath, sourceLineNumber);

		consoleAccess.WriteLineWithColor(ConsoleColor.Yellow, finalMessage);
	}

	public void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
	{
		var finalMessage = logMessageFormatter.GetMessage(LogLevel.Error, message, memberName, sourceFilePath, sourceLineNumber);

		consoleAccess.WriteLineWithColor(ConsoleColor.Red, finalMessage);
	}

	public void Fatal(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
	{
		var finalMessage = logMessageFormatter.GetMessage(LogLevel.Fatal, message, memberName, sourceFilePath, sourceLineNumber);

		consoleAccess.WriteLineWithColor(ConsoleColor.DarkRed, finalMessage);
	}
}