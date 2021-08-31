using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using AutoIt;

using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using MarsFramework.Global;
using RelevantCodes.ExtentReports;

using static NUnit.Core.NUnitFramework;
using System;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement radio1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement radio2 { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationType1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement LocationType2 { get; set; }




        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillTradeOption1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement SkillTradeOption2 { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveOption1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement ActiveOption2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }
        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }





        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }


        internal void EnterShareSkill()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "ShareSkill");
            wait(10);
            //Click ShareSkill Button
            ShareSkillButton.Click();
            //title
            wait(5);
            Title.SendKeys(ExcelLib.ReadData(2, "Title"));
            //enter description
            Description.SendKeys(ExcelLib.ReadData(2, "Description"));
            //select Cateory
            var cat1 = new SelectElement(CategoryDropDown);
            cat1.SelectByValue(ExcelLib.ReadData(2, "Category"));
            //Select SubCategory
            var scate = new SelectElement(SubCategoryDropDown);
            scate.SelectByValue(ExcelLib.ReadData(2, "SubCategory"));
            //enter tags
            Tags.SendKeys(ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            //choose service type

            radiobutton(ExcelLib.ReadData(2, "ServiceType"), "One-off service", "Hourly basis service", radio2, radio1);

            //choose Location type
            radiobutton(ExcelLib.ReadData(2, "LocationType"), "On-site", "Online", LocationType1, LocationType2);

            //select available dates
            StartDateDropDown.SendKeys(ExcelLib.ReadData(2, "Startdate"));
            EndDateDropDown.SendKeys(ExcelLib.ReadData(2, "Enddate"));

            //select availiable days
            checkbox(ExcelLib.ReadData(2, "Selectday"), ExcelLib.ReadData(2, "Starttime"), ExcelLib.ReadData(2, "Endtime"));
            // Choose skill trade
            radiobutton(ExcelLib.ReadData(2, "SkillTrade"), "Skill-exchange", "Credit", SkillTradeOption1, SkillTradeOption2);

            if (ExcelLib.ReadData(2, "SkillTrade") == "Skill-exchange")
            {


                //Enter skill exchange
                SkillExchange.SendKeys(ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                CreditAmount.SendKeys(ExcelLib.ReadData(2, "Credit"));
               
            }

            // work sample upload
            IWebElement worksample = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            worksample.Click();

            Thread.Sleep(1000);
            AutoIt.AutoItX.WinActivate("Open");
           
            AutoIt.AutoItX.Send(@"C:\Users\Jigar\Desktop\MVP\marsframework-master\SkillUpload.txt");
            AutoIt.AutoItX.Send("{Enter}");
            
            //Select enable or disable your services
            radiobutton(ExcelLib.ReadData(2, "Active"), "Active", "Hidden", ActiveOption1, ActiveOption2);

                

            //Click save button
            Save.Click();
        }

        //validate skill is added successfully
        internal void validateskill()
        {
            
            try
            {
                //Start report

                Base.test = Base.extent.StartTest("Add Share Skill");
                string ExpectedValue = ExcelLib.ReadData(2, "Title");
                string ActualValue = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
                //check expected and actual value are same
                if (ExpectedValue == ActualValue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "ShareSkil Added");



                }
                else
                
                    Base.test.Log(LogStatus.Fail, "Test fail");

                }


            catch (Exception e)

            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
        }




        internal void EditShareSkill()
        {

            ExcelLib.PopulateInCollection(ExcelPath, "ShareSkill");
            // Click on ManageListing
            wait(5);
            manageListingsLink.Click();

            //Click on Edit Button
            wait(5);
                IWebElement edit = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
                edit.Click();
                wait(5);
                //edit title
                Title.Clear();
                Title.SendKeys(ExcelLib.ReadData(5, "Title"));
                //edit description
                Description.Clear();
                Description.SendKeys(ExcelLib.ReadData(5, "Description"));
                //edit category
                var cat1 = new SelectElement(CategoryDropDown);
                cat1.SelectByValue(ExcelLib.ReadData(5, "Category"));
                //edit Subcategory
                var scate = new SelectElement(SubCategoryDropDown);
                scate.SelectByValue(ExcelLib.ReadData(5, "SubCategory"));
                //enter tags
               
                Tags.SendKeys(ExcelLib.ReadData(5, "Tags"));
                Tags.SendKeys(Keys.Enter);
                //choose service type

                radiobutton(ExcelLib.ReadData(5, "ServiceType"), "One-off service", "Hourly basis service", radio2, radio1);

                //choose Location type
                radiobutton(ExcelLib.ReadData(5, "LocationType"), "On-site", "Online", LocationType1, LocationType2);

                //select available dates
               
                StartDateDropDown.SendKeys(ExcelLib.ReadData(5, "Startdate"));
                
                EndDateDropDown.SendKeys(ExcelLib.ReadData(5, "Enddate"));

                //select availiable days
                clearcheckbox(ExcelLib.ReadData(2, "Selectday"));
                checkbox(ExcelLib.ReadData(5, "Selectday"), ExcelLib.ReadData(5, "Starttime"), ExcelLib.ReadData(5, "Endtime"));
                // Choose skill trade
                radiobutton(ExcelLib.ReadData(5, "SkillTrade"), "Skill-exchange", "Credit", SkillTradeOption1, SkillTradeOption2);

                if (ExcelLib.ReadData(5, "SkillTrade") == "Skill-exchange")
                {


                    //Enter skill exchange
                    SkillExchange.SendKeys(ExcelLib.ReadData(5, "Skill-Exchange"));
                    SkillExchange.SendKeys(Keys.Enter);
                }
                else
                {
                    
              
                    CreditAmount.SendKeys(ExcelLib.ReadData(5, "Credit"));
                }



                //edit enable or disable service

                radiobutton(ExcelLib.ReadData(5, "Active"), "Active", "Hidden", ActiveOption1, ActiveOption2);
                //Click save button
                Save.Click();


            
        }


        internal void validateeditskill()
        {

            try
            {
                //Start report

                Base.test = Base.extent.StartTest("edit Share Skill");
                string ExpectedValue = ExcelLib.ReadData(5, "Title");
                string ActualValue = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
                //check expected and actual value are same
                if (ExpectedValue == ActualValue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "ShareSkil edited");



                }
                else

                    Base.test.Log(LogStatus.Fail, "Test fail");

            }


            catch (Exception e)

            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
        }



    }
}
