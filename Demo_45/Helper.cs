using Microsoft.Extensions.Configuration;
using System.IO;

namespace Demo_45
{
    public class Helper
    {
        public static string Service()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();
            string url = config.GetValue<string>("ConnectionStrings:DefaultConnection");
            return url.ToString();
        }
    }
}
