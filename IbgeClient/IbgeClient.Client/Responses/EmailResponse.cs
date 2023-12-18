namespace IbgeClient.Client.Responses
{
    public class EmailResponse
    {
        public string Address { get; set; }
        public List<object> Notifications { get; set; }
        public bool IsValid { get; set; }
    }
}
