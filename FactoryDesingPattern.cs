
//ALL desing patterns present here mostly used : 
https://medium.com/@edin.sahbaz/exploring-design-patterns-in-net-core-204511a234cf

public interface ILogger
{
    void Log(string message);
}
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Logic to log message to a file
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        // Logic to log message to a database
    }
}

public class EmailLogger : ILogger
{
    public void Log(string message)
    {
        // Logic to send an email with the log message
    }
}


//logger factory class where objects created at single place.
public class LoggerFactory
{
    public ILogger CreateLogger(LoggerType type)
    {
        switch (type)
        {
            case LoggerType.File:
                return new FileLogger();
            case LoggerType.Database:
                return new DatabaseLogger();
            case LoggerType.Email:
                return new EmailLogger();
            default:
                throw new ArgumentException("Invalid logger type.");
        }
    }
}


//to call the logger facotory 
public class MyService
{
    private readonly ILogger _logger;

    public MyService(LoggerFactory loggerFactory)
    {
        // Get the logger based on a configuration or condition
        _logger = loggerFactory.CreateLogger(LoggerType.File);
    }

    public void DoSomething()
    {
        _logger.Log("Doing something...");
    }
}
