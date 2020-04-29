using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuppeteerSharp;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using PuppeteerSharp.Input;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using System.IO;
using Json=System.Text.Json;
using Newtonsoft.Json;

using System.Text.RegularExpressions;

namespace CodeSignalScraper
{
    public static class Scraping
    {
        public static async Task<List<(string url, string title)>> ScanAreas(Page page)
        {
            var result = new List<(string url, string title)>();
            Console.WriteLine("Scanning areas:");
            var response = await page.GoToAsync(Program.BaseUrl + "/arcade");
            var dummy = await page.WaitForSelectorAsync("div.card a");
            var linkList = await page.QuerySelectorAllAsync("div.card a");
            foreach(var link in linkList)
            {
                var url = await (await link.GetPropertyAsync("href")).JsonValueAsync<string>();
                var title = await(await(await link.QuerySelectorAsync("h4")).GetPropertyAsync("innerText")).JsonValueAsync<string>();
                Console.WriteLine($"Found area: {title}");
                result.Add((url: url, title: title));
            }
            return result;
        }
        public static async Task<List<TaskInfo>> ScanTasks(Page page, IEnumerable<(string url, string title)> areas)
        {
            var result = new List<TaskInfo>();
            foreach (var area in areas)
            {
                if (area.title == "Databases") continue;  // Does not support SQL queries.
                if (area.title == "Python") continue;  // Does not support multiple choice.
                Console.WriteLine($"Opening area {area.title}");
                var response = await page.GoToAsync(area.url);
                var dummy = await page.WaitForSelectorAsync("div.arcade-map--topic");
                Console.WriteLine($"Scanning area {area.title}");
                var topicList = await page.QuerySelectorAllAsync("div.arcade-map--topic");
                foreach (var topic in topicList)
                {
                    var span = await topic.QuerySelectorAsync("span");
                    var topicTitle = await (await span.GetPropertyAsync("innerText")).JsonValueAsync<string>();

                    var taskList = await topic.QuerySelectorAllAsync("div.arcade-map--topic-details a.arcade-map--task");
                    foreach (var task in taskList)
                    {
                        var taskUrl = await (await task.GetPropertyAsync("href")).JsonValueAsync<string>();
                        var solvedText = await (await task.GetPropertyAsync("className")).JsonValueAsync<string>();
                        var solved = !solvedText.Contains("-current") && !solvedText.Contains("-not-solved");
                        var taskTitle = await (await (await task.QuerySelectorAsync("h3")).GetPropertyAsync("innerText")).JsonValueAsync<string>();

                        result.Add(new TaskInfo(area.url, area.title, topicTitle, taskUrl, taskTitle, solved));
                    }
                }
            }
            return result;
        }

        public static async Task RetrieveTask(Page page, TaskInfo task)
        {
            Console.WriteLine($"Reading {task.Task} of {task.Topic}.");

            await page.GoToAsync(task.TaskUrl);
            await page.SetViewportAsync(new ViewPortOptions() { Height = 100000, Width = 8000, HasTouch = false, IsMobile = false });
            var source = await page.WaitForSelectorAsync("div.view-lines");
            task.Source = await (await source.GetPropertyAsync("innerText")).JsonValueAsync<string>();
            await page.SetViewportAsync(new ViewPortOptions() { Height = 800, Width = 1600, HasTouch = false, IsMobile = false });

            var desc = await page.QuerySelectorAsync("div.markdown");
            task.Description = await (await desc.GetPropertyAsync("innerText")).JsonValueAsync<string>();
            var index = task.Description.IndexOf("[C#] Syntax Tips");
            if (index > 0) task.Description = task.Description.Substring(0, index);

            task.Tests = new List<string>();
            var list = await page.QuerySelectorAllAsync("div.accordion");
            foreach(var item in list)
            {
                var btn = await item.QuerySelectorAsync("div.accordion--head");
                PuppeteerSharp.ElementHandle body;
                do
                {
                    await btn.ClickAsync();
                    body = await item.QuerySelectorAsync("div.accordion--body");
                    if (body == null) await Task.Delay(100);
                } while (body == null);
                string test;
                var warning = await body.QuerySelectorAsync("div.task-tests--warning");
                if (warning != null)
                {
                    // The test example is too big, download it.
                    var name = await (await btn.GetPropertyAsync("innerText")).JsonValueAsync<string>();
                    name = name.Replace(' ', '-') + ".json";
                    name = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", name);
                    if (File.Exists(name)) File.Delete(name);
                    var download = await warning.QuerySelectorAsync("div.button");
                    await download.ClickAsync();
                    int limit = 40;
                    while (limit-- > 0 && !File.Exists(name))
                    {
                        await Task.Delay(250);

                    }
                    if (File.Exists(name))
                    {
                        test = ReadJsonTest(name);
                    }
                    else
                    {
                        test = "Failed to download test " + name;
                    }
                }
                else
                {
                    var input = await body.QuerySelectorAsync("pre.task-tests--value");
                    if (input == null) break;
                    test = await (await input.GetPropertyAsync("innerText")).JsonValueAsync<string>();

                    input = await body.QuerySelectorAsync("pre.-answer");
                    test += "\nExpected Output: " + await (await input.GetPropertyAsync("innerText")).JsonValueAsync<string>();
                }
                task.Tests.Add(test);
            }
        }
        private static string ReadJsonTest(string filename)
        {
            var jsonText = File.ReadAllText(filename);
            var json = Json.JsonSerializer.Deserialize(jsonText, typeof(object)) as Json.JsonElement?;
            StringBuilder result = new StringBuilder();
            json.Value.TryGetProperty("input", out var input);
            foreach (var value in input.EnumerateObject())
            {
                Write(result, value.Name, value.Value);
            }
            json.Value.TryGetProperty("output", out var output);
            Write(result, "Expected Output", output);

            return result.ToString();
        }
        static Regex regexArray = new Regex(@"(?<=\d|""|\[)\s*,\s*(?=\d|""|\])");
        static Regex regexBrackets = new Regex(@"(?<=\]|\[|\d|"")\s*(?=\]|\[|\d|"")");
        static Regex regexBrackets2 = new Regex(@"(?<=\])\s*,\s*(?=\[)");
        static void Write(StringBuilder result, string name, Json.JsonElement value)
        {
            result.Append(name);
            result.Append(": ");
            var text = value.ToString();
            if (value.ValueKind == Json.JsonValueKind.Array)
            {
                text = regexArray.Replace(text, ",");
                text = regexBrackets.Replace(text, "");
                text = regexBrackets2.Replace(text, ",\n");
            }
            result.AppendLine(text);
        }
    }
}
