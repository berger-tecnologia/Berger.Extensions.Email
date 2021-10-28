﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace brg.common.extensions.Config
{
    public static class ConfigExtensions
    {
        public static IConfigurationBuilder ApplyConfig(this IConfiguration configuration, IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(env.ContentRootPath)
                    .AddJsonFile("appsettings.json", true, true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true);

            builder.AddEnvironmentVariables();

            return builder;
        }

        public static IConfigurationBuilder ApplyConfig(this IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true);

            builder.AddEnvironmentVariables();

            return builder;
        }
    }
}