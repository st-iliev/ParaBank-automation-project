using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBank_Automation.Src
{
    public partial class AboutUs
    {
        public void AssertPageTitleIsCorrect()
        {
            Assert.AreEqual("ParaSoft Demo Website", GetPageTitle());
        }
    }
}
