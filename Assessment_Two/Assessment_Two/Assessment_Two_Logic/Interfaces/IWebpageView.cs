﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assessment_Two_Logic.Model;
using System.Net;

namespace Assessment_Two_Logic.Interfaces
{
    public interface IWebpageView : IView
    {
        String Url { get; set; }
        String SiteText { get; set; }

        void DisplayWebPage(SimpleWebResponse respone);
    }
}
