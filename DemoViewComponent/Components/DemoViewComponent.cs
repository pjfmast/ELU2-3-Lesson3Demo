using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.Components {
    public class DemoViewComponent : ViewComponent {
        public IViewComponentResult Invoke() {
            return View(new ViewModelCurrentDateTime() {
                Message = $"{DateTime.Now:G}"
            });
        }
    }
}
