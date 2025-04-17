namespace FatCat.Logger;

public class FatCatLoggingSession
{
	public static FatCatLoggingSession New() => new();

	private FatCatLoggingSession() { }

	public FatCatLoggingSession UseConsole() => this;
}