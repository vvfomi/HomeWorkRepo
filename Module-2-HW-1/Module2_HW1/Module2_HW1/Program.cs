namespace Module2_HW1;

internal class Program
{
    static void Main(string[] args)
    {
        var logger = Logger.GetInstance();

        logger.LogRecording(LogEnum.Info, "Program was started. ");
        Thread.Sleep(1000);
        var logger2 = Logger.GetInstance();

        logger2.LogRecording(LogEnum.Warning, "Testing warning log.");
        Thread.Sleep(1000);
        var logger3 = Logger.GetInstance();

        logger3.LogRecording(LogEnum.Error, "Oops, something went wrong! ");

        var logs = logger.GetAllLogs();


        Console.WriteLine($"\nAll logs:\n{logs}");
    }
}