using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class EntryPointCX
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figure > img"; //Tells Selenium what steps to follow thru the HTML code. Kind of like a map
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        if (cssPathElement.Displayed) //In general CSS is better. It is better supported by the browsers & CSS is faster
        {
            GreenMessage("I can see the CSS Path Element!");
        }
        else
        {
            RedMessage("I can't see the CSS Path Element!");
        }
        if (xPathElement.Displayed)
        {
            GreenMessage("I can see the X Path Element!");
        }
        else
        {
            RedMessage("I can't see the CSS Path Element!");
        }
        driver.Quit();
    }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}