using openai.B.Services;
using OpenAI.GPT3.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "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");

        services.AddHostedService<OpenAICompletionService>();
        //services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();

