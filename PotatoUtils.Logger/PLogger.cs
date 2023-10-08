using System.Runtime.CompilerServices;

namespace PotatoUtils.Logger
{
    public static class PLogger
    {
        private static IOutputStream _outputStream;
        private static OutputFormat _outputFormat;
        private static OutputFormat _outputExceptionFormat;

        public static IOutputStream OutputStream
        {
            get => _outputStream;
            set => _outputStream = value;
        }

        public static OutputFormat OutputFormat
        {
            get => _outputFormat;
            set => _outputFormat = value;
        }

        public static OutputFormat ExceptionOutputFormat
        {
            get => _outputExceptionFormat;
            set => _outputExceptionFormat = value;
        }

        static PLogger()
        {
            
        }

        public static void SetOutputStream (IOutputStream outputStream)
        {
            _outputStream = outputStream;
        }

        public static void SetOutputFormat (OutputFormat outputFormat)
        {
            _outputFormat = outputFormat;
        }

        public static void SetOutputExceptionFormat (OutputFormat outputExceptionFormat)
        {
            _outputExceptionFormat = outputExceptionFormat;
        }

        public static void Log (string message, [CallerFilePath] string callerFileName = null, [CallerMemberName] string callerMethodName = null)
        {
            ProcessMessage(_outputFormat, message, callerFileName, callerMethodName);
        }

        public static void LogException(string message, [CallerFilePath] string callerFileName = null, [CallerMemberName] string callerMethodName = null)
        {
            ProcessMessage(_outputExceptionFormat, message, callerFileName, callerMethodName);
        }

        private static void ProcessMessage(OutputFormat format, string message, string callerFileName, string callerMethodName)
        {
            MessageInfo formatedString = format.Process(message, callerFileName, callerMethodName);
            _outputStream.WriteMessage(formatedString);
        } 
    }
}