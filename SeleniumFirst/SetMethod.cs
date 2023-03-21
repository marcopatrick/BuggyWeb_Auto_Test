using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SetMethod
    {
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertyCollection.website.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertyCollection.website.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == PropertyType.ClassName)
                PropertyCollection.website.FindElement(By.ClassName(element)).Click();
        }

        //Click Operation
        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertyCollection.website.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertyCollection.website.FindElement(By.Name(element)).Click();
            if (elementtype == PropertyType.ClassName)
                PropertyCollection.website.FindElement(By.ClassName(element)).Click();
        }

        public static void ClearTextBox(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertyCollection.website.FindElement(By.Id(element)).Clear();
            if (elementtype == PropertyType.Name)
                PropertyCollection.website.FindElement(By.Name(element)).Clear();
            if (elementtype == PropertyType.ClassName)
                PropertyCollection.website.FindElement(By.ClassName(element)).Clear();


        }

    }
}
