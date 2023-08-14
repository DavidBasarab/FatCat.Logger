﻿using System.Runtime.CompilerServices;
// ReSharper disable MethodOverloadWithOptionalParameter

namespace FatCat.Logger;

public interface IFatCatLogger
{
	void Information(string message);

	void Verbose(string message);

	void Debug(string message);

	void Warning(string message);

	void Error(string message);

	void Fatal(string message);

	void Information(string message, [CallerMemberName] string memberName = "",
					[CallerFilePath] string sourceFilePath = "",
					[CallerLineNumber] int sourceLineNumber = 0);

	void Verbose(string message, [CallerMemberName] string memberName = "",
				[CallerFilePath] string sourceFilePath = "",
				[CallerLineNumber] int sourceLineNumber = 0);

	void Debug(string message, [CallerMemberName] string memberName = "",
				[CallerFilePath] string sourceFilePath = "",
				[CallerLineNumber] int sourceLineNumber = 0);

	void Warning(string message, [CallerMemberName] string memberName = "",
				[CallerFilePath] string sourceFilePath = "",
				[CallerLineNumber] int sourceLineNumber = 0);

	void Error(string message, [CallerMemberName] string memberName = "",
				[CallerFilePath] string sourceFilePath = "",
				[CallerLineNumber] int sourceLineNumber = 0);

	void Fatal(string message, [CallerMemberName] string memberName = "",
				[CallerFilePath] string sourceFilePath = "",
				[CallerLineNumber] int sourceLineNumber = 0);
    
}

public class FatCatLogger : IFatCatLogger
{
	public void Information(string message) { throw new NotImplementedException(); }

	public void Verbose(string message) { throw new NotImplementedException(); }

	public void Debug(string message) { throw new NotImplementedException(); }

	public void Warning(string message) { throw new NotImplementedException(); }

	public void Error(string message) { throw new NotImplementedException(); }

	public void Fatal(string message) { throw new NotImplementedException(); }

	public void Information(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0) { throw new NotImplementedException(); }

	public void Verbose(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0) { throw new NotImplementedException(); }

	public void Debug(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0) { throw new NotImplementedException(); }

	public void Warning(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0) { throw new NotImplementedException(); }

	public void Error(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0) { throw new NotImplementedException(); }

	public void Fatal(string message, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0) { throw new NotImplementedException(); }
}