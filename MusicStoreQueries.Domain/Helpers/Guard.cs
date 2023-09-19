namespace MusicStoreQueries.Domain.Helpers;
public static class Guard
{
    public static T ArgumentNotNull<T>(T argumentValue, string argumentName)
    {
        if (argumentValue == null)
            throw new ArgumentNullException(argumentName);

        return argumentValue;
    }
}
