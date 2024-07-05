using OpenQA.Selenium;

namespace Co.miacademy
{
    public class ScreenshotHelper
    {
        public static string TakeScreenshot(IWebDriver driver)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var screenshotDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
            Directory.CreateDirectory(screenshotDirectory);
            string filePath = Path.Combine(screenshotDirectory, $"{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_Screenshot.png");

            using (MemoryStream memoryStream = new MemoryStream(screenshot.AsByteArray))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    memoryStream.WriteTo(fileStream);
                    fileStream.Flush();
                }
            }

            return filePath;
        }
    }
}