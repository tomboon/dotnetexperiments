using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebApplication.Services;

namespace WebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IKwartaalService, KwartaalService>();
            //container.RegisterInstance(typeof(IKwartaalService), new KwartaalService());
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}