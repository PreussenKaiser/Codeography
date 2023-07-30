using Codeography.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Immutable;

namespace Codeography;

public sealed class SoundApplication
{
    public SoundApplication(IServiceProvider serviceProvider)
    {
        this.ServiceProvider = serviceProvider;
    }

    public IServiceProvider ServiceProvider { get; }

    public static SoundApplicationBuilder CreateDefaultBuilder()
    {
        IServiceCollection services = new ServiceCollection().AddLogging(builder => builder.AddConsole());

        return new SoundApplicationBuilder(services);
    }

    public Task RunAsync()
    {
        IEnumerable<ISoundLayer> layers = this.ServiceProvider.GetServices<ISoundLayer>();
        ICollection<Task> playedSounds = new List<Task>();

        foreach (var layer in layers)
        {
            Task playedSound = layer.PlayAsync();

            playedSounds.Add(playedSound);
        }

        return Task.WhenAll(playedSounds);
    }
}
