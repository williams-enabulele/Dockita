using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dockita.Extensions
{
    public static class EmailServiceExtension
    {
        public static void EmailConfig(this IServiceCollection services, IConfiguration config)
        {
            services
            .AddFluentEmail("hello@dockita.com")
            .AddRazorRenderer()
            .AddSmtpSender("localhost", 25);
        }
    }
}