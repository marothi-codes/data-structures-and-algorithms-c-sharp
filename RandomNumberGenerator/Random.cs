namespace RandomNumberGenerator;

public class Random
{
    public static int NextInt32()
    {
        var byteArray = new byte[4];
        System.Security.Cryptography.RandomNumberGenerator.Fill(byteArray);
        return BitConverter.ToInt32(byteArray, 0);
    }

    public static double NextDouble()
    {
        var byteArray = new byte[8];
        System.Security.Cryptography.RandomNumberGenerator.Fill(byteArray);
        ulong randomValue = BitConverter.ToUInt64(byteArray, 0);
        return (double)randomValue / ulong.MaxValue; // Normalize to [0, 1]
    }

    public static float NextSingle()
    {
        var byteArray = new byte[4];
        System.Security.Cryptography.RandomNumberGenerator.Fill(byteArray);
        uint randomValue = BitConverter.ToUInt32(byteArray, 0);
        return (float)randomValue / uint.MaxValue; // Normalize to [0, 1]
    }
}
