using Codeography.Abstractions;
using Codeography.Example.Players;
using NAudio.Wave.SampleProviders;

namespace Codeography.Example.Sounds;

public sealed class LowBeepSound : ISoundLayer
{
    public async Task PlayAsync()
    {
        for (var i = 0; i < 2; i++)
        {
            WavePlayer.Play(0.2, 100, 300, SignalGeneratorType.Sin);

            await Task.Delay(500);
        }
    }
}
