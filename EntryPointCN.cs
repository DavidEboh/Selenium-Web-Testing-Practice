using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



class EntryPointCN
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/class-name/";
        string ClassName = "testClass";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.ClassName(ClassName));

        Console.WriteLine(element.Text); //Check for specific text and output it to the console

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
