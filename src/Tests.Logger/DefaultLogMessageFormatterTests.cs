using FluentAssertions;
using FakeItEasy;
using FatCat.Fakes;
using FatCat.Logger;
using FatCat.Toolkit;
using Xunit;

namespace Tests.FatCat.Logger;

public class DefaultLogMessageFormatterTests
{
	private IDateTimeUtilities dateTimeUtilities;
	private DefaultLogMessageFormatter formatter;
	private DateTime currentTime;

	public DefaultLogMessageFormatterTests()
	{
		dateTimeUtilities = A.Fake<IDateTimeUtilities>();

		currentTime = Faker.RandomDateTime();

		A.CallTo(() => dateTimeUtilities.UtcNow())
		.ReturnsLazily(() => currentTime);

		formatter = new DefaultLogMessageFormatter(dateTimeUtilities);
	}
}