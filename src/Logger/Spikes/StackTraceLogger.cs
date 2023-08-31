using System.Diagnostics;
using FatCat.Toolkit;
using FatCat.Toolkit.Console;

namespace FatCat.Logger.Spikes;

public class StackTraceLogger : IFatCatLogger
{
	private readonly ConsoleLogger consoleLogger = new(new ConsoleAccess(), new DefaultLogMessageFormatter(new DateTimeUtilities()));

	public void Debug(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		var stack = StackTraceData.Get();

		consoleLogger.Debug(message, stack.MethodName, stack.ClassName, stack.LineNumber);
	}

	public void Error(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		var stack = StackTraceData.Get();

		consoleLogger.Debug(message, stack.MethodName, stack.ClassName, stack.LineNumber);
	}

	public void Fatal(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		var stack = StackTraceData.Get();

		consoleLogger.Debug(message, stack.MethodName, stack.ClassName, stack.LineNumber);
	}

	public void Information(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		var stack = StackTraceData.Get();

		consoleLogger.Debug(message, stack.MethodName, stack.ClassName, stack.LineNumber);
	}

	public void Verbose(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		var stackTrace = new StackTrace(1, false);

		var stackFrame = stackTrace.GetFrame(0);
		var method = stackFrame.GetMethod();

		var declaringType = method.DeclaringType;
		var methodName = method.Name;
		var lineNumber = stackFrame.GetFileLineNumber();

		consoleLogger.Verbose(message, methodName, declaringType.Name, lineNumber);
	}

	public void Warning(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
		var stackTrace = new StackTrace(1, false);

		var stackFrame = stackTrace.GetFrame(0);
		var method = stackFrame.GetMethod();

		var declaringType = method.DeclaringType;
		var methodName = method.Name;
		var lineNumber = stackFrame.GetFileLineNumber();

		consoleLogger.Warning(message, methodName, declaringType.Name, lineNumber);
	}
}