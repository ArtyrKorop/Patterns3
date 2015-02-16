﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RunAttirbute : Attribute
    {
        public bool Use { get; set; }

        public int Priority { get; set; }

        public RunAttirbute(bool use = false, int priority = 0)
        {
            this.Use = use;
            this.Priority = priority;
        }
    }
}
