namespace MyLogger
{
    public interface ILogger
    {
        void Error(string text);

        void Info(string text);

        void Warning(string text);
    }
}
