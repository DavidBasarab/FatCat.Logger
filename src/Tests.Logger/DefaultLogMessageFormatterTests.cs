using FakeItEasy;
using FatCat.Fakes;
using FatCat.Logger;
using FatCat.Toolkit;
using FatCat.Toolkit.Extensions;
using FluentAssertions;
using Xunit;

namespace Tests.FatCat.Logger;

public class DefaultLogMessageFormatterTests
{
	private readonly IDateTimeUtilities dateTimeUtilities = A.Fake<IDateTimeUtilities>();
	private readonly DefaultLogMessageFormatter formatter;
	private readonly DateTime utcTime = Faker.RandomDateTime();
	private readonly DateTime localTime = Faker.RandomDateTime();
	private readonly string message = Faker.RandomString();
	private readonly string memberName = "SomeFunction";
	private readonly string sourceFilePath;
	private readonly int sourceLine = Faker.RandomInt();
	private readonly LogLevel logLevel;

	public DefaultLogMessageFormatterTests()
	{
		SetUpDateTimeUtilities();

		formatter = new DefaultLogMessageFormatter(dateTimeUtilities);

		sourceFilePath = @"C:\SomeDirectory\Another\SomeClass.cs";

		logLevel = Faker.Create<LogLevel>();
	}

	[Fact]
	public void GetTheLocalTime()
	{
		formatter.GetMessage(logLevel, message, memberName, sourceFilePath, sourceLine);

		A.CallTo(() => dateTimeUtilities.LocalNow())
		.MustHaveHappened();
	}

	[Fact]
	public void GiveALogFormat()
	{
		var expectedMessage = $"{localTime:yyyy.MM.dd HH:mm:ss:fff} | {logLevel.ToString().FixedLength(11)} | SomeClass.SomeFunction @ {sourceLine} | {message}";

		formatter.GetMessage(logLevel, message, memberName, sourceFilePath, sourceLine)
				.Should()
				.Be(expectedMessage);
	}

	private void SetUpDateTimeUtilities()
	{
		A.CallTo(() => dateTimeUtilities.UtcNow())
		.ReturnsLazily(() => utcTime);

		A.CallTo(() => dateTimeUtilities.LocalNow())
		.ReturnsLazily(() => localTime);
	}
}