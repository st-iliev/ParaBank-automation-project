﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class AboutUs
    {
        public IWebElement warningText => WaitAndFindElement(By.XPath("//*[@id='rightPanel']/p[2]"));
    }
}
