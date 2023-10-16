namespace ASFEnhanceTools.Data;

public abstract record AbstractResponse<T> : AbstractResponse
{
    public T? Result { get; init; }
}
public record AbstractResponse
{
    public string Message { get; init; } = "";
    public bool Success { get; init; }
}