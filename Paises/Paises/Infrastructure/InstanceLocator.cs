
namespace Paises.Infrastructure
{
    using ViewModels;

    public class InstanceLocator
    {
        public LoginViewModel LvM { get; set; }

        public InstanceLocator()
        {
            LvM = new LoginViewModel();
        }

    }
}
