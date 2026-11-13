using System.Diagnostics;

namespace FatCat.Logger.Spikes;

internal class StackTraceData
{
	public string ClassName { get; set; }

	public string MethodName { get; set; }

	public int LineNumber { get; set; }

	public static StackTraceData Get(int skipFrames = 1)
	{
		var stackTrace = new StackTrace(skipFrames + 1, false);

		var stackFrame = stackTrace.GetFrame(0);
		var method = stackFrame.GetMethod();

		var declaringType = method.DeclaringType;
		var methodName = method.Name;
		var lineNumber = stackFrame.GetFileLineNumber();

		return new StackTraceData
				{
					ClassName = declaringType.Name,
					LineNumber = lineNumber,
					MethodName = methodName
				};
	}
}