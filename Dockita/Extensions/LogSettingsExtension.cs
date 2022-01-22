using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Slack;
using Serilog.Sinks.Slack.Models;
using System;

namespace Dockita.Extensions
{
    public static class LogSettingsExtension
    {
        public static void SetupSerilog(this IServiceCollection services, IConfiguration config)
        {

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    path: ".\\Logs\\log-.txt",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                    rollingInterval: RollingInterval.Day,
                    restrictedToMinimumLevel: LogEventLevel.Information
                )
               .WriteTo.Slack(new SlackSinkOptions()
               {
                   WebHookUrl = "https://hooks.slack.com/services/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",
                   CustomChannel = "#dockita-loggings",
                   BatchSizeLimit = 20,
                   CustomIcon = ":memo:",
                   Period = TimeSpan.FromSeconds(10),
                   ShowDefaultAttachments = false,
                   ShowExceptionAttachments = true,
               })
               .CreateLogger();
        }
    }
}
