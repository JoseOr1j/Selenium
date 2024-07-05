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
using System.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.DevTools.V120.Page;
using OpenQA.Selenium.DevTools.V120.CSS;
[TestFixture]
public class AmazonTest {
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

    [Test]
    public static void newTest()
    {

        void repeat()
        {
            IWebDriver driver = new ChromeDriver();

            /* driver . something is what the code can touch */
            driver.Navigate().GoToUrl("https://amazon.com");

            driver.ToString();


            Assert.That(driver.Title, Is.EqualTo("Amazon.com"));

            for (int i = 0; i < 2; i++)
            {
                driver.GetHashCode();
                driver.GetType();
            }

            if (driver.Title == "Amazon.com")
            {
                Console.Write("This is an amazon website");
            }
            else if (driver.Title == "Amazon Labs.com")
            {
                Console.Write(driver.Title);
                Console.WriteLine("This is another amazon site");
            }
            else
            {
                Console.WriteLine("This is not an amazon site.. now quitting");
                driver.Quit();
            }
        }

        repeat();
        
    }

    [Test]
    public static void clickOnItem()
    {
        IWebDriver driver = new ChromeDriver();

        

        driver.Navigate().GoToUrl("https://Amazon.com");

        driver.ToString();

        Assert.That(driver.Equals("ELEMENT"), Is.EqualTo(true));
       

        Assert.That(driver.Equals("https://amazon.com"), Is.True);

        Assert.That(driver.Url.Equals("https://amazon.com"), Is.True);

        string urlName = driver.Url.ToString();
        Console.Write(urlName);

        if (urlName == "https://amazon.com")
        {
            Console.Write("Url name checks out: ", urlName):
        }
        else if (urlName == "https://amazon.co")
        {
            Console.Write("Mistyped, retype url");
        }
        else
        {
            Console.WriteLine("No valid url");
        }

        

        driver.Url = "https://amazon.com";

        String title = driver.Title; 

        int TitleLength = driver.Title.Length;

        Console.WriteLine("This title of this age is: ", title," and the length is: ", TitleLength);

        string PageUrl = driver.Url;

        int PageSourceLength = driver.PageSource.Length;

        driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();

        driver.Quit();

    }

    [Test]
public static void clickOnItem2()
    {
        IWebDriver driver = new ChromeDriver();
        driver.FindElements(By.Id("name"));
        int titleLength = driver.Title.Length + 1;
        Console.WriteLine(titleLength);

        string pageUrl = driver.Url;
    }

    /* this is where it was */

    [Test]

    public static void clickOnTitle()
    {
        IWebDriver driver = new ChromeDriver();
        driver.FindElement(By.XPath("string"));

        driver.FindElement(By.CssSelector("title")).Click();

        int titleLength = driver.Title.Length;
        Console.WriteLine(titleLength + 1);

        string pageUrl = driver.Url;

        Console.WriteLine("this is the URL of the profile: ", pageUrl);

        driver.Navigate().GoToUrl(pageUrl);

        driver.SwitchTo().Window(pageUrl);

        driver.SwitchTo().Window(pageUrl); driver.SwitchTo().Window(pageUrl);

        driver.SwitchTo().Window(pageUrl);

        Console.WriteLine(driver.ToString());
        Console.WriteLine(pageUrl);

        driver.FindElement(By.XPath(""));

        driver.FindElement(By.ClassName(pageUrl)).Click();

        driver.FindElement(By.Name("title")).Click();

        driver.FindElement(By.ClassName("title"));



        driver.Quit();
    }

    [Test]
    static void addToCart()
    {
        // test case for adding an item to a amazon shopping cart
        /*
         * P1 goes to Amazons webpage
         * P1 searches for an item in the search box 
         * P1 submits search
         * P1 selects an item 
         * P1 adds item to cart and clicks it
         * P1 verifies that the item was added 
         * */
        IWebDriver driver = new ChromeDriver();

        try
        {
            driver.Navigate().GoToUrl("https://www.amazon.com");

            var searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys("Selenium WebDriver book");
            searchBox.Submit();

            // WAITS for the results to load 
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(By.CssSelector(".s-search-results .s-results-item")));

            //find and click the first item in search
            var firstResult = driver.FindElement(By.CssSelector("s-search results"));
            // var name = driver (driver command) (by select what driver will touch);

            firstResult.Click();

            wait.Until(d => d.FindElement(By.Id("productTitle")));

            // find and click add to cart
            var addToCartButton = driver.FindElement(By.Id("add-to-cart-button"));
            addToCartButton.Click();

            // wait to confirm it was added 

            wait.Until(d => d.FindElement(By.CssSelector(".a-size-medium-plus")));

          
        }

        catch (NoSuchElementException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            driver.Quit();
        }

    }

}
