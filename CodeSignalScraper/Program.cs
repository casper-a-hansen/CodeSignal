// Known issues:
// fixed Names with many capital letters like HTML End Tag By Start Tag is convert to hTMLEndTagByStartTag and not to htmlEndTagByStartTag
// fixed Names with - is converted wrong e.g. Kill K-th bit -> killKThBit should be killKthBit
// fixed Lines in source are shown wrapped and therefor they appear wrapped, it is a problem when comments seems to be code.
// fixed Mixing LF and CR/LF, seems to be in description
// fixed Mixing LF and CR/LF, when writing tests for the test method (when Test case is too long)
// fixed Cannot read test that are too long
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
            Browser(args.Contains("headless", StringComparer.OrdinalIgnoreCase)).Wait();
            /* If you get an exception like this you need to close Chromium before running
             * System.AggregateException: 'One or more errors occurred. (Failed to launch 
             * Chromium! [3436:8788:0429/225643.770:ERROR:cache_util_win.cc(21)] Unable to 
             * move the cache: Access is denied. (0x5)
             */
        }

        static async Task Browser(bool headless)
        {
            Console.WriteLine("Loading chromium");
            var fetcher = new BrowserFetcher();
            await fetcher.DownloadAsync(BrowserFetcher.DefaultRevision);
            using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                UserDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Puppeteer"),
                Headless = headless,
                DefaultViewport = new ViewPortOptions { IsMobile = false, HasTouch = false, IsLandscape = true, Width = 1600, Height = 800 },
            });
            Console.WriteLine("Loading codesignal.com");
            var pages = await browser.PagesAsync();
            var page = pages.Length > 0 ? pages[0] : await browser.NewPageAsync();
            var areas = (await Scraping.ScanAreas(page));
            var tasks = (await Scraping.ScanTasks(page, areas));
            Console.WriteLine($"Located {tasks.Count} tasks where {tasks.Count(t => t.Solved)} is solved");
            Console.WriteLine("Please note that only solved tasks and first new task and unlocked tasks are found!");

            tasks = Source.FilterTasks(tasks).ToList();
            Console.WriteLine($"Retrieving {tasks.Count} task to update source and tests.");

            int failed = 0;
            //            var tasks = new TaskInfo[] { new TaskInfo("https://app.codesignal.com/arcade/code-arcade", "The Core", "Cliffs Of Pain", "https://app.codesignal.com/arcade/code-arcade/cliffs-of-pain/iGBDQE3KjqbYyF8DH", "timeASCIIRepresentation", false) };
            foreach (var task in tasks)
            {
                await Scraping.RetrieveTask(page, task);
                if (task.Failed)
                {
                    failed++;
                    continue;
                }
                Source.WriteTask(task);
                task.Description = null;
                task.Source = null;
                task.Tests = null;
            }

            Console.WriteLine("Finished, press space to end the program.");
            if (failed != 0)
            {
                Console.WriteLine();
                Console.WriteLine($"However, failed to import {failed} tasks.");
                Console.WriteLine($"Please, rerun to try again.");
            }

            Console.ReadKey();
            await page.CloseAsync();
            await browser.CloseAsync();
        }
    }
}
