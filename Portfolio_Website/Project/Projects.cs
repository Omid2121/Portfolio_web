using System;
using System.Collections.Generic;

namespace ProjectsNamespace
{
    public class Project
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string DownloadBtn { get; set; }
    }

    public static class Projects
    {
        public static List<Project> list = new List<Project>
        {
            new Project
            {
                Image = "497_449074_management.hero.jpg",
                Name = "Project 1",
                Text = "About project 1",
                DownloadBtn = "",
            },
            new Project
            {
                Image = "497_449074_management.hero.jpg",
                Name = "Project 2",
                Text = "About project 2",
                DownloadBtn = "",
            },
            new Project
            {
                Image = "497_449074_management.hero.jpg",
                Name = "Project 3",
                Text = "About project 3",
                DownloadBtn = "",
            }
        };
    }
}
