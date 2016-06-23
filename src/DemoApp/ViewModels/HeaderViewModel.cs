using System.Collections.Generic;

namespace DemoApp.ViewModels
{
    public class HeaderViewModel
    {
        public IEnumerable<NavigationItemViewModel> NavigationItems { get; set; }

        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}