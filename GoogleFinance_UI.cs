using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeInterview_Automation
{
    internal class GoogleFinance_UI
    {
        public string baseURL = "https://www.google.com/finance/quote/SOFI:NASDAQ";
        IWebDriver chromeDriver;
        public void StartExecution()
        {
            //Setup
            chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(baseURL);

            //Scroll down to the location of the element
            WebElement element = (WebElement)chromeDriver.FindElement(By.ClassName("T4hLP"));
            ((IJavaScriptExecutor)chromeDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

            //Search element to click the financial values of each quarter
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var verifyFinancialValues = chromeDriver.FindElements(By.ClassName("Dez8Wc"));

            //Cycle through each element
            for (int i = 0; i < verifyFinancialValues.Count; i++)
            {
                if (verifyFinancialValues.Count > 0)
                {    
                    verifyFinancialValues[i].Click();
                }
            }
            
        }
    }
}
