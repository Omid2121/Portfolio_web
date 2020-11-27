using System;
using System.Collections.Generic;
using System.Text;

namespace AboutNameSpace
{
    public class About
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
    public static class Abouts
    {
        public static List<About> list = new List<About>
        {
            new About
            {
                Image = "image/me.jpg",
                Name = "Omidreza Ahangi",
                Text = "About me",
            }
        };
    }
}
