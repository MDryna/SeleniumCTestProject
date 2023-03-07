using System;
using OpenQA.Selenium;

namespace TestQa.PageObjects
{
	public class HomePage : BaseTests
    {
        IWebElement lnkSignIn => driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogOff => driver.FindElement(By.XPath("//a[@href='javascript:document.getElementById('logoutForm').submit()']"));
        // не працює IWebElement lnkEmployeeDetails => driver.FindElement(By.XPath("//a[@href='/EmployeeDetails']"));


        public void ClickLogin() => lnkSignIn.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;

        public void OpenEmployeeDetails() => lnkEmployeeDetails.Click();


    }
}

