using System;
using System.Diagnostics;

namespace AssemVer
{
    class Program
    {
        static void Main(string[] args)
        {                      
            var myAssembly = System.Runtime.Loader.AssemblyLoadContext.Default.LoadFromAssemblyPath(@"F:\Shabs\prj\rnd\dc\testaspnetcore\myMVC\bin\Debug\netcoreapp1.1.1\myMVC.dll");
            var versionstr = myAssembly.GetName().Version.ToString();
            string fileVersion = FileVersionInfo.GetVersionInfo(myAssembly.Location).FileVersion;
            string productVersion = FileVersionInfo.GetVersionInfo(myAssembly.Location).ProductVersion;
            Console.WriteLine($"Simple Version: {versionstr}");
            Console.WriteLine($"File Version: {fileVersion}");
            Console.WriteLine($"Product Version: {productVersion}");
            Console.ReadLine();
        }
    }
}