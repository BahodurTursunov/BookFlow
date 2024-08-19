namespace BookFlow.Models.DTOs
{
    public class UserSession
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}
