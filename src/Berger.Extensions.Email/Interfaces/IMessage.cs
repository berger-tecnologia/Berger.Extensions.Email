namespace Berger.Extensions.Email
{
    public interface IMessage<T>
    {
        public string Body { get; set; }
        public string Data { get; set; }
        public string Subject { get; set; }
        public string Target { get; set; }
    }
}