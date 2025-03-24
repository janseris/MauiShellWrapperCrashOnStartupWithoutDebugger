# MauiShellWrapperCrashOnStartupWithoutDebugger
.NET 9 MAUI bug reproduction repository (9.0.50)

Debug mode with debugger attached on Android 11 and 12: OK

Debug mode without debugger attached: crash

This is a minimal sample from a larger app where instead of crash, plain black or plain white screen was shown in the application depending on light/dark mode.

For issue: https://github.com/dotnet/maui/issues/28575
