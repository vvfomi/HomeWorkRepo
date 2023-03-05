using System.Text;

namespace Module2_HW1;

public class Logger
{
    private static Logger _instance;
    private StringBuilder _logs;
    private FileService _fileService;

    private Logger()
    {
        _logs = new StringBuilder();
        _fileService = new FileService();
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
        string folderName = "D:\\Projects\\HomeWorkRepo\\Module-2-HW-1\\Module2_HW1\\Module2_HW1\\Logs\\";
        string fileName = $"Logs.{DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.txt";

        _fileService.CreateFile(folderName, fileName, GetAllLogs()); 
    }
}

