﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MarconnetDotFr_2018.Helper
{
    public class XMLHelper
    {
        public static string GetValue(XElement element, string name)
        {
            return element.Element(name) == null ? "" : element.Element(name).Value;
        }
    }
}