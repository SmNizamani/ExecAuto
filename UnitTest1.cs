using Microsoft.Playwright;

namespace PlaywrightDemo;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless=false
            });
        var page = await browser.NewPageAsync();
        await page.GotoAsync(url:"http://www.eaapp.somee.com");
        await page.ClickAsync(selector:"text=Login");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path="Screenshot1.jpg"
        }
        );

    }
}