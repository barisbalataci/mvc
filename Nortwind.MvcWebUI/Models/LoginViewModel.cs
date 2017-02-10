using Project.Shared.DataTypes.Entities;

namespace Nortwind.MvcWebUI.Models
{
    public class LoginViewModel
    {
        public User User { get; set; }
        public bool RememberMe { get; set; }
    }
}