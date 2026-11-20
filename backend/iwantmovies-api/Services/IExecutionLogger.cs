namespace IWantMovies.Api.Services;

public interface IExecutionLogger
{
    void Log(string operation, TimeSpan elapsed);
}