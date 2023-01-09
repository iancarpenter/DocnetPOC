using Docnet.Core;
using Docnet.Core.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var docReader = DocLib.Instance.GetDocReader(@"C:\Temp\EMegane.pdf", new PageDimensions()))
            {
                for (var i = 0; i < docReader.GetPageCount(); i++)
                {
                    using (var pageReader = docReader.GetPageReader(i))
                    {
                        var text = pageReader.GetText();
                        Console.WriteLine(text);
                    }
                }
            }

        }
    }
}