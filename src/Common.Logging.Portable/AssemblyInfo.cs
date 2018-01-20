
using System.Runtime.CompilerServices;

using Common.Logging;

[assembly: System.Security.SecurityTransparent]

[assembly: TypeForwardedTo(typeof(FormatMessageHandler))]
[assembly: TypeForwardedTo(typeof(IConfigurationReader))]
[assembly: TypeForwardedTo(typeof(ILog))]
[assembly: TypeForwardedTo(typeof(ILoggerFactoryAdapter))]
[assembly: TypeForwardedTo(typeof(ILogManager))]
[assembly: TypeForwardedTo(typeof(IVariablesContext))]
[assembly: TypeForwardedTo(typeof(LogLevel))]