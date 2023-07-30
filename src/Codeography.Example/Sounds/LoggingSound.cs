using Codeography.Abstractions;
using Microsoft.Extensions.Logging;

namespace Codeography.Example.Sounds;

public sealed class LoggingSound : ISoundLayer
{
    private readonly ILogger<LoggingSound> logger;

    public LoggingSound(ILogger<LoggingSound> logger)
    {
        this.logger = logger;
    }

    public async Task PlayAsync()
    {
        const int LOOPS = 10;
        const int BPM = 60;
        
        for (var i = 0; i <= LOOPS; i++)
        {
            this.logger.LogInformation("Played sound {increment} time(s)!", i);

            int milliseconds = BPM / 60 * 1000;

            await Task.Delay(milliseconds);
        }
    }
}
