using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestQa
{
    public class BaseTests

    {
        public static IWebDriver driver;


        [SetUp]
        public void SetUp() 
        {
          driver = new ChromeDriver();
          driver.Navigate().GoToUrl("http://eaapp.somee.com/");//ініціалізуємо вебдрайвер

        }

         
        [TearDown]
        public void TearDown()
        {
           // driver.Quit();
        }


        //public static string BaseUrl = "";


        //protected IWebDriver driver; //можна визвати у будь-яких класах

        //[OneTimeSetUp]

        //protected void DoBeforeAllTheTests() //виконується один раз перед запуском тестів
        //{
        //    driver = new ChromeDriver();//ініціалізуємо вебдрайвер

        //}


        //[SetUp]
        //public void Setup()
        //{

        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    driver.Manage().Cookies.DeleteAllCookies();//чисти кукіси перд усіма тестами
        //    driver.Navigate().GoToUrl(BaseUrl); ; //вказуємо UrІ, що збережено у файлі TestSettings 
        //    driver.Manage().Window.Maximize();  //команда для вивденя Chrome на весь екран монітору
        //}

        //[Test]
        //public void Test1()
        //{

        //    Assert.That(actual: driver.Title, Is.EqualTo("BlazingChat"));
        //}

        //[Test]
        //public void Test2()
        //{
        //    //enter email
        //    var input = driver.FindElement(By.Id("input_emailaddress"));
        //    input.Clear();
        //    input.SendKeys("julius.caesar@gmail.com");

        //    //enter password
        //    input = driver.FindElement(By.Id("input_password"));
        //    input.Clear();
        //    input.SendKeys("julius.caesar");

        //    //click on the login
        //    Thread.Sleep(5000);
        //    input = driver.FindElement(By.Id("button_login"));
        //    input.Click();

        //    //Validatee login message
        //    var startTimestamp = DateTime.Now.Millisecond;
        //    var endTimestamp = startTimestamp + 5000;

        //    while (true)
        //    {
        //        try
        //        {
        //            input = driver.FindElement(By.Id("p_welcome_message"));
        //            Assert.That(input.Text, Is.EqualTo("Hello, julius.caesar@gmail.com"));
        //            break;

        //        }
        //        catch
        //        {
        //            var currentTimestamp = DateTime.Now.Microsecond;
        //            if (currentTimestamp > endTimestamp)
        //            {
        //                throw;
        //            }
        //            Thread.Sleep(2000);
        //        }


    }
}
    //protected IWebDriver driver; //можна визвати у будь-яких класах

    //[OneTimeSetUp]

    //protected void DoBeforeAllTheTests() //виконується один раз перед запуском тестів
    //{
    //    driver = new ChromeDriver();//ініціалізуємо вебдрайвер

    //}




    //[SetUp]
    //protected void DobeforeEach()//виконуються перед кожним тестом
    //{
    //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    //    driver.Manage().Cookies.DeleteAllCookies();//чисти кукіси перд усіма тестами
    //    driver.Navigate().GoToUrl(TestSettings.HostUrl); //вказуємо UrІ, що збережено у файлі TestSettings 
    //    driver.Manage().Window.Maximize();  //команда для вивденя Chrome на весь екран монітору

    //}


