using Puffix.Cqrs.Startup;
using Puffix.IoC;

namespace Puffix.Cqrs.IoC
{
    /// <summary>
    /// Interface pour intégrer
    /// </summary>
    public interface IIoCStartupConfiguration : IStartupConfiguration, IIoCContainer
    { }
}
