namespace BlogProject.Client.Services
{
    public class BenutzersService : IBenutzersService
    {
        private readonly HttpClient _http;
        public BenutzersService(HttpClient http)
        {
            _http = http;
        }
    }
}
