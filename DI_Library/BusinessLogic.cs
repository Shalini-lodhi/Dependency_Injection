using DI_Library.Utilities;

namespace DI_Library
{
    public class BusinessLogic
    {
        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Starting the processing of data");
            Console.WriteLine("Processing the data");

            dataAccess.SaveData("ProcessedInfo");
            logger.Log("Finished processing of the data.");
        }
    }
}