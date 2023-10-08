using Xunit.Sdk;
using PotatoUtils.Logger;
using PotatoUtils.Logger.Utils;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace PotatoUtils.Logger.Tests
{
    public class LoggerTests
    {
        [Fact]
        public void MainLoggerActivity()
        {
            string output = "";
            string exceptOutput =
                "testLog1;\n" +
                "testLog2;\n" +
                "testLog3;\n";
            StringHolder stringHolder = new StringHolder(output);
            IOutputStream outputStream = new FileOutputStream("testLog.log");
            OutputFormat outputFormat = new DefaultOutputFormat();
            OutputFormat outputExceptionFormat = new DefaultOutputExceptionFormat();

            PLogger.SetOutputStream(outputStream);
            PLogger.SetOutputFormat(outputFormat);
            PLogger.SetOutputExceptionFormat(outputExceptionFormat);

            PLogger.Log("testLog1");
            PLogger.Log("testLog2");
            PLogger.Log("testLog4");

            
            Assert.Equal(exceptOutput, stringHolder.Value);
        }
    }
}