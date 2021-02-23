using Microsoft.AspNetCore.Mvc;
using System;
using ViewComponentsDemo.Models;

// todo 1. Create a ViewComponent in Components
namespace ViewComponentsDemo.Components {
    public class DemoViewComponent : ViewComponent {
        public IViewComponentResult Invoke() {
            return View(new ViewModelCurrentDateTime() {
                Message = $"{DateTime.Now:G}"
            });
        }
    }
}
