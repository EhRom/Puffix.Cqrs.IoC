using Puffix.Cqrs.Startup;
using Puffix.IoC;

namespace Puffix.Cqrs.IoC
{
    public interface IIoCStartupConfiguration : IStartupConfiguration, IIoCContainer
    { }
}
