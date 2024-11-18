using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace AutoJobLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            string userID = "33537";
            int wybor;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Start pracy");
                Console.WriteLine("2. Koniec pracy");
                Console.WriteLine("3. Wyjście");
                Console.Write("Wybierz opcję (1-3): ");

                if (!int.TryParse(Console.ReadLine(), out wybor))
                {
                    Console.WriteLine("Nieprawidłowy wybór. Naciśnij dowolny klawisz, aby spróbować ponownie...");
                    Console.ReadKey();
                    continue;
                }

                switch(wybor)
                {
                    case 1:
                        using (IWebDriver driver = new EdgeDriver())
                        {
                            driver.Navigate().GoToUrl("https://ords-swd.pgf.com.pl/ords/f?p=105:1::::::");

                            IWebElement wroclawBtn = driver.FindElement(By.CssSelector("#R14377095374412552_jqm_list_view > li:nth-child(13) > a"));
                            wroclawBtn.Click();
                            IWebElement automatykBtn = driver.FindElement(By.CssSelector("#R4822318975764142_jqm_list_view > li:nth-child(13) > a"));
                            automatykBtn.Click();
                            IWebElement fieldId = driver.FindElement(By.Id("P1002_PRAC_SZUK"));
                            fieldId.SendKeys(userID);
                            fieldId.SendKeys(Keys.Enter);
                            IWebElement startBtn = driver.FindElement(By.CssSelector("#R22916864967462837_jqm_list_view > li > a"));
                            startBtn.Click();

                            Console.WriteLine("Zalogowałeś się pomyślnie");
                        }
                        break;

                    case 2:
                        using (IWebDriver driver = new EdgeDriver())
                        {
                            driver.Navigate().GoToUrl("https://ords-swd.pgf.com.pl/ords/f?p=105:1::::::");

                            IWebElement wroclawBtn = driver.FindElement(By.CssSelector("#R14377095374412552_jqm_list_view > li:nth-child(13) > a"));
                            wroclawBtn.Click();
                            IWebElement automatykBtn = driver.FindElement(By.CssSelector("#R4822318975764142_jqm_list_view > li:nth-child(13) > a"));
                            automatykBtn.Click();
                            IWebElement fieldId = driver.FindElement(By.Id("P1002_PRAC_SZUK"));
                            fieldId.SendKeys(userID);
                            fieldId.SendKeys(Keys.Enter);
                            IWebElement endBtn = driver.FindElement(By.CssSelector("#t_TreeNav_4 > div.a-TreeView-content > a"));
                            endBtn.Click();

                            IWebElement logOut = driver.FindElement(By.Id("P1003_PRAC_SZUK"));
                            logOut.SendKeys(userID);
                            logOut.SendKeys(Keys.Enter);

                            Console.WriteLine("Wylogowałeś się pomyślnie");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Zamykanie programu...");
                        break;


                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            } while (wybor != 4);




        }
    }
}