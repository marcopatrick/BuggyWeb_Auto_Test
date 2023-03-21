using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class GetMethods
    {

        public static string GetText(string element, string elementtype) 
        {
            if(elementtype == "Id")
                return PropertyCollection.website.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return PropertyCollection.website.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;


        }
    }
}
