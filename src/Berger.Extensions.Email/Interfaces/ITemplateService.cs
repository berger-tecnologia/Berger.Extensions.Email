namespace Berger.Extensions.Email
{
    public interface ITemplateService
    {
        string Process(string body, string data);
    }
}