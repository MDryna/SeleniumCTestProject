using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Text;
using TestQa.PageObjects;

namespace TestQa; 

public class Tests : BaseTests
{
	//[Test]
	//public void NegativeLogin()
	//{
	//	driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
	//	driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

	//	CustomElements.CustomBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

	//   }

	[Test]
	public void LoginTest()
	{
        HomePage homePage = new HomePage();
		SignInPage signInPage = new SignInPage();

		homePage.ClickLogin();
		signInPage.EnterUserName("admin");
		Thread.Sleep(2000);
		signInPage.EnterPassword("password");
		signInPage.ClickLogin();

		Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button did not displayed");

    }

	[Test]
	public void EmployeeDetails()
	{
        HomePage homePage = new HomePage();
        SignInPage signInPage = new SignInPage();

        homePage.ClickLogin();
        signInPage.EnterUserName("admin");
        Thread.Sleep(2000);
        signInPage.EnterPassword("password");
        signInPage.ClickLogin();
        Thread.Sleep(2000);
        homePage.OpenEmployeeDetails();

    }


}

