using AbstractSite.Enums;
using AbstractSite.Factories;
using AbstractSite.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSite.Controllers
{
    public class NotificationController : Controller
    {
        private readonly IAccountProvider _accountProvider;

        public NotificationController(IAccountProvider accountProvider)
        {
            _accountProvider = accountProvider;
        }

        public IActionResult Index()
        {
            INotificationFactory factory = new ReviewNotificationFactory(NotificationState.VIEW, _accountProvider);
            return View(factory);
        }
    }
}
