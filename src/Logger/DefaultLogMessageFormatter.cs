using FatCat.Toolkit;

namespace FatCat.Logger;

public interface ILogMessageFormatter
{
	string GetMessage(LogLevel logLevel, string message, string memberName, string sourceFilePath, int sourceLineNumber);
}

public class DefaultLogMessageFormatter : ILogMessageFormatter
{
	private readonly IDateTimeUtilities dateTimeUtilities;

	public DefaultLogMessageFormatter(IDateTimeUtilities dateTimeUtilities) => this.dateTimeUtilities = dateTimeUtilities;

	public string GetMessage(LogLevel logLevel, string message, string memberName, string sourceFilePath, int sourceLineNumber)
	{
		return "TODO";
	}
}