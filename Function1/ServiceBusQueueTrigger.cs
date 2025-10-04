
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureFunctionProject.Function1
{
    public static class ServiceBusQueueTrigger // Ensure the class is public
    {
        [FunctionName("ServiceBusQueueTrigger")]
        public static void Run(
            [ServiceBusTrigger("pan-first-queue", Connection = "ServiceBusConnectionString")] string myQueueItem,
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}