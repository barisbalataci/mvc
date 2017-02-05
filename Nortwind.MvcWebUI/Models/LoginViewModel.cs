using Nortwind.Entities.Concrete;

namespace Nortwind.MvcWebUI.Models
{
    public class LoginViewModel
    {
        public User User { get; set; }
        public bool RememberMe { get; set; }
    }
}