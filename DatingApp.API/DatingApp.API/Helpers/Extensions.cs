using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            // adds application error header
            response.Headers.Add("Application-Error", message);
            // exposes application error header
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            // adds access control allow origin all
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}