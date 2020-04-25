using System;
using System.IO;
using System.Threading.Tasks;
using PuppeteerSharp;

namespace CodeSignalScraper
{
    class Program
    {
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
            var response = await page.GoToAsync("https://app.codesignal.com/arcade");
            await Task.Delay(1000);
            var header = await page.QuerySelectorAsync("main h1");
            var title = header.GetPropertyAsync("innerText");
            Console.WriteLine(title);

            Console.ReadKey();
            await page.CloseAsync();
            await browser.CloseAsync();
        }
    }
}
