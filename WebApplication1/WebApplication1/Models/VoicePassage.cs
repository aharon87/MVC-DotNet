﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class VoicePassage
    {
        public string Title { get; set; }
        public string FileName { get; set; }
        public HttpPostedFileBase Recording { get; set; }
    }
}