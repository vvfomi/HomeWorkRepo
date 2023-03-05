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
            try
            {
                switch (number)
                {
                    case 1:
                        actions.GetInfoResult();
                        break;
                    case 2:
                        actions.GetWarningResult();
                        break;
                    case 3:
                        actions.GetErrorResult();
                        break;
                }
            }
            catch (BussinessException ex)
            {
                logger.LogRecording(LogEnum.Warning, $"Action got this custom Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                logger.LogRecording(LogEnum.Error, $"Action failed by reason: {ex}");
            }
        }

        logger.SaveAllLogsToFile();
    }
}
