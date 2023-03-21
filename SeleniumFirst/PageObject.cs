using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class PageObject
    {
        [FindsBy(How = How.Name)]
        public IWebElement Name { get; set; }
    }
}
