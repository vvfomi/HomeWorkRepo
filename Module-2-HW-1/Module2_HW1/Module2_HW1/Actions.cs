namespace Module2_HW1;

public class Actions
{

    public Result GetInfoResult()
    {
        Result result = new Result();
        result.Message = "Start method:";

        result.Status = true;

        var logger = Logger.GetInstance();
        logger.LogRecording(LogEnum.Info, result.Message);

        return result;
    }

    public Result GetWarningResult()
    {
        Result result = new Result();
        result.Message = "Skipped logic in method:";

        result.Status = true;

        var logger = Logger.GetInstance();
        logger.LogRecording(LogEnum.Warning, result.Message);

        return result;
    }

    public Result GetErrorResult()
    {
        Result result = new Result();
        result.Message = "I broke a logic:";

        result.Status = false;

        var logger = Logger.GetInstance();
        logger.LogRecording(LogEnum.Error, result.Message);

        return result;
    }
}
