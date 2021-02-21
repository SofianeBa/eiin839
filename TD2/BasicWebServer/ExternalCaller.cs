using System;
using System.Diagnostics;
using System.IO;
using System.Net;

class ExternalCaller
{
    public static string Main(HttpListenerRequest request)
    {
        //
        // Set up the process with the ProcessStartInfo class.
        // https://www.dotnetperls.com/process
        //
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = @"C:\Users\SofianeB\Desktop\Polytech\4A\Soc\TD2\ExecTest\bin\Debug\ExecTest.exe"; // Specify exe name.
        start.Arguments = request.Url.Query; // Specify arguments.
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;
        //
        // Start the process.
        //
        using (Process process = Process.Start(start))
        {
            //
            // Read in all the text from the process with the StreamReader.
            //
            using (StreamReader reader = process.StandardOutput)
            {
                return reader.ReadToEnd();
            }
        }
    }
}