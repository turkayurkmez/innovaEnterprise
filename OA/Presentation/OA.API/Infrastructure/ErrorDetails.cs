namespace OA.API.Infrastructure
{
    public class ErrorDetails
    {
        public ErrorDetails()
        {
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}