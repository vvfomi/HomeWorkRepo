namespace Module2_HW1;

public class Starter
{

    public void Run()
    {
        Actions actions = new Actions();
        var logger = Logger.GetInstance();

        for (int i = 0; i < 100; i++)
        {
            int number = new Random().Next(1, 4);
            Result result = new Result();

            switch (number)
            {
                case 1:
                    result = actions.GetInfoResult();
                    break;
                case 2:
                    result = actions.GetWarningResult();
                    break;
                case 3:
                    result = actions.GetErrorResult();
                    break;
            }

            if (result.Status == false)
            {
                logger.LogRecording(LogEnum.Error, "Action failed by а reason: " + result.Message);
            }

        }

        logger.SaveAllLogsToFile();
    }
}
