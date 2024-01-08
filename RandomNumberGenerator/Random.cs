using System.Security.Cryptography;

namespace CustomRandomNumberGenerator;

public class Random
{
    public static int NextInt32()
    {
        var byteArray = new byte[4];
        RandomNumberGenerator.Fill(byteArray);
        return BitConverter.ToInt32(byteArray, 0);
    }

    public static double NextDouble()
    {
        var byteArray = new byte[8];
        RandomNumberGenerator.Fill(byteArray);
        ulong randomValue = BitConverter.ToUInt64(byteArray, 0);
        return (double)randomValue / ulong.MaxValue; // Normalize to [0, 1]
    }

    public static float NextSingle()
    {
        var byteArray = new byte[4];
        RandomNumberGenerator.Fill(byteArray);
        uint randomValue = BitConverter.ToUInt32(byteArray, 0);
        return (float)randomValue / uint.MaxValue; // Normalize to [0, 1]
    }

    public static int NextInt32(int minValue, int maxValue)
    {
        var scale = (double)ulong.MaxValue;
        var range = (long)maxValue - minValue;
        var randomValue = NextDouble() * scale;
        return (int)(minValue + (long)(range * randomValue / scale));
    }

    public static double NextDouble(double minValue, double maxValue)
    {
        var scale = (double)ulong.MaxValue;
        var range = maxValue - minValue;
        var randomValue = NextDouble() * scale;
        return minValue + range * randomValue / scale;
    }

    public static float NextSingle(float minValue, float maxValue)
    {
        var scale = (float)uint.MaxValue;
        var range = maxValue - minValue;
        var randomValue = NextSingle() * scale;
        return minValue + range * randomValue / scale;
    }
}
