using Codeography.Abstractions;
using Codeography.Example.Players;
using NAudio.Wave.SampleProviders;

namespace Codeography.Example.Sounds
{
    public sealed class LongBeepSound : ISoundLayer
    {
        public async Task PlayAsync()
        {
            WavePlayer.Play(0.5, 250, 500, SignalGeneratorType.Sin);
        }
    }
}
