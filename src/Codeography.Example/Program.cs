using Codeography;
using Codeography.Example.Sounds;
using Codeography.Extensions;

var builder = SoundApplication
        .CreateDefaultBuilder()
        .ConfigureServices(services => services
            .AddSoundLayer<LoggingSound>()
            .AddSoundLayer<BeepSound>());

var app = builder.Build();

await app.RunAsync();
