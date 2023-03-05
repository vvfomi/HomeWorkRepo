namespace Module2_HW1;

public class Actions
{

    public bool GetInfoResult()
    {
        var message = "Start method:";

        bool getInfo = true;

        var logger = Logger.GetInstance();
        logger.LogRecording(LogEnum.Info, message);

        return getInfo;
    }

    public bool GetWarningResult()
    {
        var message = "Skipped logic in method:";
        throw new BussinessException(message);


        return false;
    }

    public bool GetErrorResult()
    {

        var message = "I broke a logic:";
        throw new Exception(message);


        return false;
    }
}
