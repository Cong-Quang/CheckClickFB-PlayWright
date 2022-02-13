using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();
var chromium = playwright.Chromium;
var browser = await chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false});
var context = await browser.NewContextAsync();
await context.RouteAsync("**/*", route => route.ContinueAsync());
var page = await context.NewPageAsync();
await page.PauseAsync();