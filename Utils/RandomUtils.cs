namespace CSharpRPG.Utils;

public static class RandomUtils
{

    public static int GetRandomBetween(int min, int max)
    {
        Random number = new Random();
        return number.Next(min, max);
    }
}
