namespace Application.Core
{
    public sealed record ValidationError(string PropertyName, string ErrorMessage);
}