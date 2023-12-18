namespace IbgeClient.Client.Responses
{
    public class AuthResponse
    {
        public UserResponse User { get; set; }
        public string Token { get; set; }
    }

    public class UserResponse
    {
        public EmailResponse Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Guid Id { get; set; }
    }
}
