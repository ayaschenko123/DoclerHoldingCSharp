//using System;
//using OpenQA.Selenium;

//namespace DoclerTestsNUnit
//{
//private static IWebDriver webDriver;
//private static string baseURL = ConfigurationManager.AppSettings["url"];
//private static string browser = ConfigurationManager.AppSettings["browser"];
//public static void Init()
//{
//	switch (browser)
//	{
//		case "Chrome":
//			webDriver = new ChromeDriver();
//			break;
//		case "IE":
//			webDriver = new InternetExplorerDriver();
//			break;
//		case "Firefox":
//			webDriver = new FirefoxDriver();
//			break;
//	}
//	webDriver.Manage().Window.Maximize();
//	Goto(baseURL);
//}
//public static string Title
//{
//	get { return webDriver.Title; }
//}
//public static IWebDriver getDriver
//{
//	get { return webDriver; }
//}
//public static void Goto(string url)
//{
//	webDriver.Url = url;
//}
//public static void Close()
//{
//	webDriver.Quit();
//}
//}