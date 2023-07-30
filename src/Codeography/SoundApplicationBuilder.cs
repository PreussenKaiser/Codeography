using Microsoft.Extensions.DependencyInjection;

namespace Codeography;

public sealed class SoundApplicationBuilder
{
    public SoundApplicationBuilder(IServiceCollection services)
    {
        this.Services = services;
    }

    public IServiceCollection Services { get; }

    public SoundApplicationBuilder ConfigureServices(Action<IServiceCollection> action)
    {
        action(this.Services);

        return this;
    }

    public SoundApplication Build()
    {
        return new SoundApplication(this.Services.BuildServiceProvider());
    }
}
