using Puffix.Cqrs.Startup;
using Puffix.IoC;

namespace Puffix.Cqrs.IoC
{
    /// <summary>
    /// Interface pour intégrer
    /// </summary>
    interface IIoCStartupConfiguration : IStartupConfiguration, IIoCContainer
    { }
}
