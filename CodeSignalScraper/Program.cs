using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace CodeSignalScraper
{
    class Program
    {
        public static readonly string BaseUrl = "https://app.codesignal.com";
        static void Main(string[] args)
        {
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
            var areas = (await Scraping.ScanAreas(page));
            var tasks = (await Scraping.ScanTasks(page, areas));
            Console.WriteLine($"Located {tasks.Count} tasks where {tasks.Count(t => t.Solved)} is solved");
            Console.WriteLine("Please note that only solved tasks and first new task and unlocked tasks are found!");

            tasks = Source.FilterTasks(tasks).ToList();
            Console.WriteLine($"Retrieving {tasks.Count} task to update source and tests.");

            foreach(var task in tasks.Take(10))
            {
                await Scraping.RetrieveTask(page, task);
                Source.WriteTask(task);
                task.Description = null;
                task.Source = null;
                task.Tests = null;
            }


            Console.ReadKey();
            await page.CloseAsync();
            await browser.CloseAsync();
        }
    }
}
