using FluentAssertions;
using FakeItEasy;
using FatCat.Logger;
using FatCat.Toolkit.Console;
using Xunit;

namespace Tests.FatCat.Logger;

public class ConsoleLoggerTests
{
	[Fact]
	public void CanActuallyCreateAConsoleLoggerClass()
	{
		var consoleLogger = new ConsoleLogger(A.Fake<IConsoleAccess>());
	}
}