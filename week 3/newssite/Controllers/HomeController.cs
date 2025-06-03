using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.item;

namespace newssite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<NewsItem> newsItems = new List<NewsItem>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        newsItems.Add(new NewsItem()
        {
            Title = "Dit bericht is nieuw",
            Content = "Lijstjes ook met newsitems",
            ImageUrl = "img/newsitem.png"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "Mijn eerste model",
            Content = "was niet zo moeilijk",
            ImageUrl = "img/newsitem.png"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "Mijn tweede model",
            Content = "was nog makkelijker",
            ImageUrl = "img/newsitem.png"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "Mijn derde model",
            Content = "was nog makkelijker",
            ImageUrl = "img/newsitem.png"
        });
    }

    public IActionResult Index()
    {
        return View(newsItems);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
