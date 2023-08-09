using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Codeography.Example.Players;

public static class WavePlayer
{
    public static void Play(double gain, double frequency, int duration, SignalGeneratorType waveType)
    {
        ISampleProvider sine20Seconds = new SignalGenerator()
        {
            Gain = gain,
            Frequency = frequency,
            Type = waveType
        }
        .Take(TimeSpan.FromMilliseconds(duration));

        using WaveOutEvent waveOut = new();

        waveOut.Init(sine20Seconds);
        waveOut.Play();

        while (waveOut.PlaybackState == PlaybackState.Playing)
        {
            Thread.Sleep(500);
        }
    }
}
