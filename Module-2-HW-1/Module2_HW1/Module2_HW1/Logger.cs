using System.Text;

namespace Module2_HW1;

public class Logger
{
    private static Logger _instance;
    private StringBuilder _logs;

    private Logger()
    {
        _logs = new StringBuilder();
    }

    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void LogRecording(LogEnum logEnum, string message)
    {
        string log = $"{DateTime.Now}: {logEnum}: {message}";
        Console.WriteLine(log);

        _logs.AppendLine(log);
    }

    public string GetAllLogs()
    {
        return _logs.ToString();
    }

    public void SaveAllLogsToFile()
    {
        File.WriteAllText("log.txt", _logs.ToString());
    }
}

