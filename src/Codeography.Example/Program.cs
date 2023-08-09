using Codeography;
using Codeography.Example.Sounds;
using Codeography.Extensions;

await SoundApplication
        .CreateDefaultBuilder()
        .ConfigureServices(services => services
            .AddSoundLayer<LoggingSound>()
            .AddSoundLayer<HighBeepSound>()
            .AddSoundLayer<LowBeepSound>()
            .AddSoundLayer<LongBeepSound>())
        .Build()
        .RunAsync();
