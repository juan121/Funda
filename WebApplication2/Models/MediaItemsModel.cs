﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MediaItemsModel
    {
        public int Category { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public string Url { get; set; }
    }
}