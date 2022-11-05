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
            Assert.AreEqual("ParaBank | About Us", GetPageTitle());
        }
        public void AssertWarrningTextIsCorrect()
        {
            Assert.AreEqual("In other words: ParaBank is not a real bank!",warningText.Text);
        }
    }
}
