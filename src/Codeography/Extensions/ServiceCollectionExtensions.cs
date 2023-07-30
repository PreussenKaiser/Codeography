using Codeography.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Codeography.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSoundLayer<TSoundLayer>(this IServiceCollection services)
            where TSoundLayer : class, ISoundLayer
    {
        return services. AddSingleton<ISoundLayer, TSoundLayer>();
    }
}
