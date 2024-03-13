namespace OznurYilmazBackEnd.Models
{
    public class RevokeToken
    {
        //why not required?? you can catch the token from the body of the request or from cookie
        public string? Token { get; set; }
    }
}
