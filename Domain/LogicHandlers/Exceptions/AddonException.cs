namespace Domain.LogicHandlers.Exceptions;

public class AddonException : Exception
{
    public AddonException(string? message) : base(message)
    {
    }
}