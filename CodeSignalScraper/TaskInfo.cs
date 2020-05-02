using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignalScraper
{
    public class TaskInfo
    {
        public TaskInfo(string areaUrl, string area, string topic, string taskUrl, string task, bool solved)
        {
            AreaUrl = areaUrl;
            Area = area;
            Topic = topic;
            TaskUrl = taskUrl;
            Task = task;
            Solved = solved;
            Failed = false;
        }

        public void UpdateTaskName(string name)
        {
            Task = name;
        }
        public string AreaUrl { get; private set; }
        public string Area { get; private set; }
        public string Topic { get; private set; }
        public string TaskUrl { get; private set; }
        public string Task { get; private set; }
        public bool Solved { get; private set; }

        public bool Failed;

        public string Description;

        public string Source;

        public List<string> Tests;
    }
}
