// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Linq.Expressions;
using System.CodeDom;
[TestFixture]
public class MedicalCareTabTest {
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp() {
        driver = new ChromeDriver();
        /*options.BrowserExecutableLocation = (C:\\Program Files\\)*/
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown() {
        driver.Quit();
    }
    /* new code */

    /*
         * CSS Selectors
         * .class symbolizes all elements by the given class name
         * #id selects all elements by the given ID
         * element selects all elements by the given tag name
         * attribute selects all elements with a specific attrubute 


    public void FirstSeleniumTest()
    { 
        IWebDriver driver = new ChromeDriver();

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.selenium.dev/");

        Assert.That(driver.Title, Is.EqualTo("Selenium"));

         // class name IwebElement checks to see if element is displayed 
         var classNameValidator = driver.FindElement(By.ClassName("DocSearc")).Displayed;

         // ths should fail because there is no .DocSearch class found in the website code 

         Assert.That(classNameValidator, Is.EqualTo(true));

         var cssSelectorValidator = driver.FindElement(By.ClassName("DocSearc")).Displayed;
         Assert.That(classNameValidator, Is.EqualTo(true));

         // ensure that IDs are unique for test cases 

         // id 

         var idValidator = driver.FindElement(By.Id("selenium-logo")).Displayed;
         Assert.That(idValidator, Is.EqualTo(true));

        driver.Quit();
       
    }

    [Test]

    public void SecondSeleniumTest()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.selenium.dev/");

        Assert.That(driver.Title, Is.EqualTo("Selenium"));

        var classNameValidator = driver.FindElement(By.ClassName("td-home")).Displayed;

        Assert.That(classNameValidator, Is.EqualTo(true));

        // this should pass because there is a class element named td-home in the code 
    }

    [Test]
    public void ThirdSeleniumTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Minimize();

        driver.Navigate().GoToUrl("https://www.selenium.dev");

        var classNameValidator = driver.FindElement(By.ClassName("td-offset-anchor")).Displayed;

        Assert.That(classNameValidator, Is.EqualTo(true));
    }
    */

    [Test]
    public void ClairTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://getclair.com/how-clair-works");

        var classNameValidator = driver.FindElement(By.ClassName("container hcw-container w-container")).Displayed;
        Assert.That(classNameValidator, Is.EqualTo(true));

        driver.Quit();
    }
    /*
     * Practice test to see if a web browser opens and gets title name, title length
     * Steps to Reproduce:
     * Launch a new Chrome browswer
     * Open Store Demo QA Website
     * Get Page Title name and Length
     * Print Page Title length on console
     * Close the Browser
     * 
     * This tests if our website is up and running 
     * */
    [Test]
    public void OpenWebTest()
    {
        IWebDriver driver = new ChromeDriver();
        //Launch ToolsQA Site
        driver.Url = "https://demoqa.com";

        // stores title name in string variable 
        String Title = driver.Title;

        // stores title length in int var
        int TitleLength = driver.Title.Length;


        // PRINTS TITLE NAME ON CONSOLE
        Console.WriteLine("Title of the page is", Title);

        // print title length
        Console.WriteLine("Length of the title is " + TitleLength);

        // storing URL in string variable
        string PageUrl = driver.Url;


        driver.Quit();

    }
    // Browser 
    [Test]
    public void browserCommands()
    {
        IWebDriver driver = new ChromeDriver();
        // Launch ToolsQA Website 
        driver.Url = "https://demoqa/com/frames-and-windows/";

        driver.FindElement(By.XPath(".//*[@id='tabs-1'] /div/p/a")).Click();
        driver.Close();
    }
    /*
     * Navigation commands is used to navigate around the browser, allows you to move backards
     * and forwards in the browser history:
     * Four Commands - GoToUrl, Back, Forward, Refresh
     */
    [Test]
    public void navigationCommands()
    {
        IWebDriver driver = new ChromeDriver();
        // void INavigation.Go.To.Url(String Url) new page from url 
        driver.Navigate().GoToUrl("https://toolsqa.com");
        // back command to navigate to previous page 
        driver.Navigate().Back();
        // forward command to navigate to new page 
        driver.Navigate().Forward();
        //refreshes the browser 
        driver.Navigate().Refresh();

        // in a sample test case 



    }

    /* Test for Navigating website regsitration link 
     * P1 opens a new chrome driver 
     * P1 then navigates to sample website 
     * P1 finds registration link using Xpath 
     * P1 clicks on "back" command to go to the home page 
     * P1 clicks on forward to return back to regsitration link
     * P1 then refreshes the web page 
     * P1 closes the browser 
     */

    [Test]
    public void browserNavigationCommands()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://demoqa.com");

        driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();

        driver.Navigate().Back();

        driver.Navigate().Forward();

        driver.Navigate().Refresh();

        driver.Close();
    }

    [Test]
    public void WebElementCommands()
    {
        // web elememt commands are used with "tags" from HTML code 
        // such as <p> Hello my first HTML element <p>

        IWebDriver driver = new ChromeDriver();

        // clear command 

        driver.FindElement(By.Id("UserName")).Clear();

        // click command 
        driver.FindElement(By.LinkText("ToolsQA")).Click();


        // further test case implementtajion 

        /*
    p1 launches new browswer 
    P1 opens URL site
    P1 types on name and last name using name locator 
    P1 clicks on Submit button with ID locator 

        
         * */

        driver.Url = ("https://toolsqa.com/Automation-practice-form");

        // types name in the first name text box 
        driver.FindElement(By.Name("firstname")).SendKeys("Sharma");

        // click on submit
        driver.FindElement(By.Id("submit")).Click();

    }

    [Test]
    public void testTwo()
    {
        IWebDriver driver = new ChromeDriver();
        /*
         * P1 launches new web browser 
         * P1 clicks on the link partual link test
         */

        Console.WriteLine("Gabriela and Drake Collab");


    }
    /*
    [Test]
    public void TitleTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Minimize();


        driver.Navigate().GoToUrl("https://www.google.com/");

        string currentUrl1 = driver.Url;

        System.Threading.Thread.Sleep(2000);

        var classNameValidator = driver.FindElement(By.ClassName("google")).Displayed;
        Assert.That(classNameValidator, Is.EqualTo(true));

        // Check if the current URL matches the expected URL of the destination page
        if (currentUrl1 == "https://www.google.com/")
        {
            Console.WriteLine("Button click successfully redirected to the expected page.");
        }
        else
        {
            Console.WriteLine("Button click did not redirect to the expected page.");
        }

        driver.Quit();
    }

    [Test]

    public void LocatorsTest()
    {
        var results = new List<string>();

        IWebDriver driver = new ChromeDriver();

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://www.selenium.dev/");

        Assert.That(driver.Title, Is.EqualTo("Selenium"));

        // h2 heading 

        // find element
        var firstH2 = driver.FindElement(By.XPath("//h2"));
        results.Add($"FindElement: {firstH2.Text}");

        // find elements
        var h2Collection = driver.FindElements(By.XPath("//h2"));
        foreach (var h2 in h2Collection)
        {
            results.Add($"FindElements: {h2.Text}");
        }

        driver.Quit();
    }
    */

    /* public void medicalCareTab() {
       driver.Navigate().GoToUrl("https://www.amazon.com/ref=nav_logo");
       vars["title"] = driver.Title;
       if ((Boolean) js.ExecuteScript("return (arguments[0]!=\'Amazon\')", vars["title"])) {
         driver.Navigate().GoToUrl("https://www.amazon.jobs/en/a");
       }
       driver.Manage().Window.Size = new System.Drawing.Size(783, 824);
       js.ExecuteScript("window.scrollTo(0,3988.800048828125)");
       driver.FindElement(By.LinkText("Careers")).Click();
       driver.Close();
     }
    */
}
