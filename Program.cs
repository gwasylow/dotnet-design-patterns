using System;

// This example uses Figgle for a large ASCII banner.
// To enable Figgle, add the NuGet package:
//   dotnet add package Figgle
// Then run:
//   dotnet run

using Figgle;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Standard.Render("Hello World! Welcome to Design Patterns in C#"));
        }
    }
}
