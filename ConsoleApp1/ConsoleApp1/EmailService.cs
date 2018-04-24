namespace ConsoleApp1
{
    public interface IEmailService
    {

    }

    public class EmailServiceClient : System.ServiceModel.ClientBase<IEmailService>, IEmailService
    {
    }
}