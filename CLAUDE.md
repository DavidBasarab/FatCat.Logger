# FatCat.Logger Coding Standards

This file defines the coding standards for the FatCat.Logger codebase.
All code you generate — in any context — must follow the rules for the relevant language below.
The goal is that AI-generated code is indistinguishable from code written by a senior member of this team.

## ⚠️ READ THIS FIRST — Before Any Work

**Before doing anything else in this repository — reading, planning, or writing code — read [`README.md`](README.md) in full.**
It is the single source of truth for what this product is and how it is built. Do not skip it, even for a "small" change.

The README tells you the things you must know before you touch a line of code:
- **Product:** FatCat.Logger — an early-stage NuGet logging library (`FatCat.Logger`). Callers log through `IFatCatLogger` (`Debug`, `Verbose`, `Information`, `Warning`, `Error`, `Fatal`), which captures the caller's member name, file path, and line number via `[CallerMemberName]` / `[CallerFilePath]` / `[CallerLineNumber]`. `ConsoleLogger` writes each level in its own colour through the FatCat.Toolkit `IConsoleAccess`, and `ILogMessageFormatter` / `DefaultLogMessageFormatter` builds the `time | level | Class.Member @ line | message` line. `FatCatLogger`, `FatCatLog`, and the fluent `FatCatLoggingSession` are still stubs; `Spikes/` holds a stack-trace experiment. Planned features (rolling files, fluent configuration, runtime log-level changes, background-thread writing) are listed in `src/Logger/IdeasLog.txt`.
- **Tech stack:** **.NET 11 / C# 15** (`LangVersion` latest) class library built on the **FatCat.Toolkit** (console access, `IDateTimeUtilities`, string extensions). Tests use **xUnit**, **FakeItEasy**, **FatCat.Fakes**, and **FluentAssertions**. There is no UI, web server, or database in this repo.
- **Architecture:** `Logger` is the shipped library; `Tests.Logger` holds its unit tests; `OneOff` is a scratch console app for trying the logger by hand and is not shipped.
- **Standing rules:** this is a published package — changes to a public interface (`IFatCatLogger`, `ILogMessageFormatter`) or the `LogLevel` enum are breaking changes for consumers, and the version is stepped in `VersionPrefix` in `Logger.csproj`.

If anything below in the coding standards appears to conflict with the README, the README describes *what* the system is; these rules describe *how* to write code for it — follow both. Where the README and the actual code disagree, **the code is authoritative** — trust the code and flag the stale README.

## Repository Layout

| Path | Project | Purpose |
|---|---|---|
| `src/Logger` | `FatCat.Logger` | The NuGet library: `IFatCatLogger`, `ConsoleLogger`, `ILogMessageFormatter` / `DefaultLogMessageFormatter`, `LogLevel`, `FatCatLoggingSession`, and the `Spikes/` stack-trace experiment |
| `src/Tests.Logger` | `Tests.FatCat.Logger` | xUnit tests for `FatCat.Logger` (`ConsoleLoggerTests`, `DefaultLogMessageFormatterTests`) |
| `src/OneOff` | `OneOff` | Console app for manually exercising the logger; not shipped |

All production namespaces start with `FatCat.Logger.*`; test namespaces start with `Tests.FatCat.Logger.*`.

Everything must build and every test must pass before work is considered done:
```bash
dotnet build src/Logger.slnx
dotnet test src/Logger.slnx
```

---

## C# Rules

Apply these rules to all C# code. Do not apply them to TypeScript, PowerShell, or any other language.

@.claude/rules/csharp/naming-and-structure.md
@.claude/rules/csharp/types-and-di.md
@.claude/rules/csharp/toolchain.md
@.claude/rules/csharp/async.md
@.claude/rules/csharp/errors-and-logging.md
@.claude/rules/csharp/testing.md
@.claude/rules/csharp/not-allowed.md

## PowerShell Rules

Apply these rules to all PowerShell scripts. Do not apply them to C# or any other language.

@.claude/rules/powershell/powershell.md
