﻿using System.Collections.Generic;

namespace CSharpGeckoBoardPush.Widgets.Text
{
    public class Data
    {
        public Data()
        {
            Item = new List<Item>();
        }

        public List<Item> Item { get; set; }
    }
}