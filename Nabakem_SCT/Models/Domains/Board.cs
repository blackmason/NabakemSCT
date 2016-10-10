﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nabakem_SCT.Models.Domains
{
    public class Board
    {
        public string No { get; set; }
        public string Category { get; set; }
        public string Fixed { get; set; }
        public string Subject { get; set; }
        public string Contents { get; set; }
        public string Author { get; set; }
        public string InsertDate { get; set; }
        public string Hit { get; set; }
        public string Bbs { get; set; }
    }
}