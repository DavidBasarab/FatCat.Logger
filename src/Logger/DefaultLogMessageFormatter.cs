using FatCat.Logger.TempToBeRemoved;

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
		var currentTime = dateTimeUtilities.LocalNow();

		// Current Date | Log Level | ClassFileName.MemberName @ LineNumber | Message
		var fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
        

		return $"{currentTime:yyyy.MM.dd HH:mm:ss:fff} | {logLevel} | {fileName}.{memberName} @ {sourceLineNumber} | {message}";
	}
}