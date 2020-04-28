// Known issues:
// fixed Names with many capital letters like HTML End Tag By Start Tag is convert to hTMLEndTagByStartTag and not to htmlEndTagByStartTag
// fixed Names with - is converted wrong e.g. Kill K-th bit -> killKThBit should be killKthBit
// fixed Lines in source are shown wrapped and therefor they appear wrapped, it is a problem when comments seems to be code.
// fixed Mixing LF and CR/LF, seems to be in description
// fixed Mixing LF and CR/LF, when writing tests for the test method (when Test case is too long)
// Cannot read test that are too long
// Does not support changes of parameter names.
// Fixed - Spaces in the source are 160 and not 32, its a problem in constants.
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using PuppeteerSharp;

namespace CodeSignalScraper
{
    class Program
    {
        public static readonly string BaseUrl = "https://app.codesignal.com";
        static void Main(string[] args)
        {
            //new Test().SourceIndent(); return;
            Browser().Wait();
        }

        static async Task Browser()
        {
            Console.WriteLine("Loading chromium");
            var fetcher = new BrowserFetcher();
            await fetcher.DownloadAsync(BrowserFetcher.DefaultRevision);
            using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                UserDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Puppeteer"),
                Headless = false,
                DefaultViewport = new ViewPortOptions { IsMobile = false, HasTouch = false, IsLandscape = true, Width = 1600, Height = 800 },
            });
            Console.WriteLine("Loading codesignal.com");
            var pages = await browser.PagesAsync();
            var page = pages.Length > 0 ? pages[0] : await browser.NewPageAsync();
            /*            var areas = (await Scraping.ScanAreas(page));
                        var tasks = (await Scraping.ScanTasks(page, areas));
                        Console.WriteLine($"Located {tasks.Count} tasks where {tasks.Count(t => t.Solved)} is solved");
                        Console.WriteLine("Please note that only solved tasks and first new task and unlocked tasks are found!");

                        tasks = Source.FilterTasks(tasks).ToList();
                        Console.WriteLine($"Retrieving {tasks.Count} task to update source and tests.");*/

            var tasks = new TaskInfo[] { new TaskInfo("https://app.codesignal.com/arcade/code-arcade", "The Core", "Cliffs Of Pain", "https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/iGBDQE3KjqbYyF8DH", "timeASCIIRepresentation", false) };
            foreach(var task in tasks)
            {
                await Scraping.RetrieveTask(page, task);
                Source.WriteTask(task);
                task.Description = null;
                task.Source = null;
                task.Tests = null;
            }

            Console.WriteLine("Finished, press space to end the program.");
            Console.ReadKey();
            await page.CloseAsync();
            await browser.CloseAsync();
        }
    }
}
