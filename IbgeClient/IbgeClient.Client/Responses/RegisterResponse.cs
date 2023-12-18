namespace IbgeClient.Client.Responses
{
    public class RegisterResponse
    {
        public Email email { get; set; }
        public string password { get; set; }
    }

    public class Email
    {
        public string address { get; set; }
        public List<object> notifications { get; set; }
        public bool isValid { get; set; }
    }
}
