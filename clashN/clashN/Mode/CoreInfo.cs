﻿using System;
using System.Collections.Generic;

namespace clashN.Mode
{
    [Serializable]
    public class CoreInfo
    {
        public ECoreType coreType { get; set; }

        public List<string> coreExes { get; set; }

        public string arguments { get; set; }

        public string coreUrl { get; set; }
    }
}