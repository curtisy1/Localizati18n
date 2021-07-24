﻿namespace Localizati18n.IntegrationTests.Controllers {
  using System.Diagnostics;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.Extensions.Logging;
  using Localizati18n.IntegrationTests.Models;
  using Localization;
  
  public class HomeController : Controller {
    private readonly ILogger<HomeController> logger;

    public HomeController(ILogger<HomeController> logger) {
      this.logger = logger;
    }

    public IActionResult Index() {
      return this.View();
    }

    public IActionResult Privacy() {
      return this.View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
    }
  }
}