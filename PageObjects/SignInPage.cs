using System;
using OpenQA.Selenium;

namespace TestQa.PageObjects

{
	public class SignInPage : BaseTests
	{

        IWebElement txtUserName => driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserName(string userName)
		{
           txtUserName.SendKeys(userName);

		}

        public void EnterPassword(string password)
        {
            txtPassword.SendKeys(password);

        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}

