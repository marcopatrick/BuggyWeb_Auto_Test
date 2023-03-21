using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    enum PropertyType
    {
        Id,
        Name,
        ClassName,
        LinkText,
        CssName
    }
    class PropertyCollection
    {
        public static IWebDriver website { get; set; }
    }
}
