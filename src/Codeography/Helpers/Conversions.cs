namespace Codeography.Helpers;

public static class Conversions
{
    public static int BpmToMilliseconds(double bpm)
    {
        const double SECONDS_IN_MINUTE = 60;
        const double MILLISECONDS_IN_SECONDS = 1000;

        double result = bpm / SECONDS_IN_MINUTE * MILLISECONDS_IN_SECONDS;

        return (int)result;
    }
}
