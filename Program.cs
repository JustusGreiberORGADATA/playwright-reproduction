using System.Threading.Tasks;
using Microsoft.Playwright;

using (var playwright = await Playwright.CreateAsync())
await using (var browser = await playwright.Chromium.LaunchAsync())
await using (var context = await browser.NewContextAsync()) {
	var page = await context.NewPageAsync();
	await page.GotoAsync("https://www.theverge.com");
	Console.WriteLine((await page.QuerySelectorAllAsync(".flex")).Count);
}
