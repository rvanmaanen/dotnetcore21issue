using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var berichtService = new EmailServiceClient();

            berichtService.Endpoint.EndpointBehaviors.Add(new CustomBehavior());
        }
    }
}
