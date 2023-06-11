namespace src.Shared
{
  public class ExceptionHandler : Exception
  {
    private string _message;

    public ExceptionHandler(string message)
    {
      _message = message;
    }

    public static ExceptionHandler FileNotFound(string message)
    {
      return new ExceptionHandler(message ?? "File not found");
    }
  }
}