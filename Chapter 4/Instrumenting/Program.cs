using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            // text write is buffered, so this option calls Flush() on all
            // listeners after writing
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I'm watching");
            Trace.WriteLine("Trace says, I am watching");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(
                displayName: "PacktSwitch",
                description: "This switch is set via a JSON config."
            );

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLine(ts.TraceError, "Trace Error");
            Trace.WriteLine(ts.TraceWarning, "Trace Warning");
            Trace.WriteLine(ts.TraceInfo, "Trace Info");
            Trace.WriteLine(ts.TraceVerbose, "Trace Verbose");

        }
    }
}
