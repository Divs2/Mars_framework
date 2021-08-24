using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(1000);
            manageListingsLink.Click();
            string ExpectedValue = ExcelLib.ReadData(2, "Title");
            Thread.Sleep(2000);
            string ActualValue = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
            if(ExpectedValue == ActualValue)
            {
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")).Click();
                if(ExcelLib.ReadData(2, "DeleteAction")=="Yes")
                {
                    driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]")).Click();
                }
                else
                {
                    driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]")).Click();
                }
            }
        }
         internal void validatedelete()
        {
            try
            {
                //Start report

                Base.test = Base.extent.StartTest("Delete Share Skill");
                IList<IWebElement> messages = driver.FindElements(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).ToList();
                foreach (IWebElement message in messages)
                {
                    if (message.Text == ExcelLib.ReadData(2, "Title"))
                    {
                        Base.test.Log(LogStatus.Pass, "Test pass");
                        SaveScreenShotClass.SaveScreenshot(driver, "ShareSkil deleted");



                    }
                    else

                        Base.test.Log(LogStatus.Fail, "Test fail");

                }
            }

            catch (Exception e)

            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
        }

    }
}

