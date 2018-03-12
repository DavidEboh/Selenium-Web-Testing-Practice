using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPointID
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/id/";
        string ID = "testImage"; //creates string for the ID
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebElement element = driver.FindElement(By.Id(ID)); //Extracts the ID from the string

        if (element.Displayed)
        {
            GreenMessage("Yes, I can see it");
        }
        else
        {
            RedMessage("No, I can not see it");
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


