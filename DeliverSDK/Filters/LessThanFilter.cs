﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverSDK
{
    public class LessThanFilter : BaseFilter, IFilter
    {
        public LessThanFilter(string element, string value)
            : base(element, value)
        {
            Operator = "[lt]";
        }
    }
}