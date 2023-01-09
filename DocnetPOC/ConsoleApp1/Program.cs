using Docnet.Core;
using Docnet.Core.Models;
using Docnet.Core.Readers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (IDocReader docReader = DocLib.Instance.GetDocReader(@"C:\Temp\EMegane.pdf", new PageDimensions()))
            {
                for (int i = 0; i < docReader.GetPageCount(); i++)
                {
                    using (IPageReader pageReader = docReader.GetPageReader(i))
                    {
                        string text = pageReader.GetText();
                        Console.WriteLine(text);
                    }
                }
            }

        }
    }
}