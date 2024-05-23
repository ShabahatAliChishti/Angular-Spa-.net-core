using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWC.PurePac.Models
{
    public class MenuItemViewModel
    {
        public MenuItemViewModel()
        {
            SubMenu = new List<MenuItemViewModel>();
        }

        public string Text { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool Selected { get; set; }
        public bool FixedURL { get; set; }
        public string FixedURLString { get; set; }
        public int LoggedInUserLogonTypeId { get; set; }
        public bool? DefaultClosed { get; set; }
        public int Navigation_Parent { get; set; }

        public List<MenuItemViewModel> SubMenu { get; set; }

    }
}