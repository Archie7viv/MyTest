namespace Infrastructure
{
    public interface ILogger
    {
        void Error(string text);

        void Info(string text);

        void Warning(string text);
    }
}
