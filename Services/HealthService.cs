namespace Day2ApiPractice.Services
{
    public class HealthService : IHealthService
    {
        public string GetHealthStatus()
        {
            return "API is running fine";
        }
    }
}