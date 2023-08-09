using Codeography.Abstractions;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Codeography.Example.Sounds;

public sealed class BeepSound : ISoundLayer
{
    public Task PlayAsync()
    {
        ISampleProvider sine20Seconds = new SignalGenerator()
        {
            Gain = 0.2,
            Frequency = 500,
            Type = SignalGeneratorType.Sin
        }
        .Take(TimeSpan.FromSeconds(20));

        using (WaveOutEvent waveOut = new())
        {
            waveOut.Init(sine20Seconds);
            waveOut.Play();
            
            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(500);
            }
        }

        return Task.CompletedTask;
    }
}
